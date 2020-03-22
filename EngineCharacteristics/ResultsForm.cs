using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using System.Windows.Media;

namespace EngineCharacteristics
{
    public partial class ResultsForm : Form
    {

        public ResultsForm()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            ShowResults();
            DoGraphs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DoSaveExcel();
        }



        private void ShowResults()
        {
            this.Text = $"Модель {InitialData.EngineModel}";

            lblCoefTorque.Text = ("По моменту: " + InitialData.Km);

            lblCoefFrequency.Text = ("По частоте: " + InitialData.Kn);

            lblCoefA.Text = ("a= " + InitialData.a);

            lblCoefB.Text = ("b= " + InitialData.b);

            lblCoefC.Text = ("c= " + InitialData.c);

            lblCoefSum.Text = ("Сумма: " + (InitialData.a + InitialData.b + InitialData.c));

            using (var context = new MyDbContext())
            {
                dataGridView1.DataSource = context.Results.ToList();
                dataGridView1.Columns["Id"].Visible = false;
            }
        }

        private void DoGraphs()
        {
            List<double> Frequency;
            List<double> Power;
            List<double> Torque;
            List<double> Consumption;

            using (var context = new MyDbContext())
            {
                Frequency = context.Results.Select(Results => Results.Frequency).ToList();
                Power = context.Results.Select(Results => Results.Power).ToList();
                Torque = context.Results.Select(Results => Results.Torque).ToList();
                Consumption = context.Results.Select(Results => Results.Consumption).ToList();
            }

            // Power chart
            #region Power chart

            ChartValues<ObservablePoint> ListPowerPoints = new ChartValues<ObservablePoint>();

            for (int i = 0; i < Frequency.Count; i++)
            {
                ListPowerPoints.Add(new ObservablePoint
                {
                    X = Frequency[i],
                    Y = Power[i]
                });
            }

            chrtPower.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Мощность:",
                    Values = ListPowerPoints,
                    LineSmoothness = 1
                }
            };

            chrtPower.Background = new SolidColorBrush(Colors.Cornsilk);

            chrtPower.AxisX.Add(new Axis
            {
                Title = "Обороты двигателя",
                FontSize = 20,
                Foreground = new SolidColorBrush(Colors.Black),
                LabelFormatter = value => value + " об/мин"
            });

            chrtPower.AxisY.Add(new Axis
            {
                Title = "Мощность двигателя",
                FontSize = 20,
                Foreground = new SolidColorBrush(Colors.Black),
                LabelFormatter = value => value + " кВт"
            });

            #endregion

            // Torque chart
            #region Torque chart

            ChartValues<ObservablePoint> ListTorquePoints = new ChartValues<ObservablePoint>();

            for (int i = 0; i < Frequency.Count; i++)
            {
                ListTorquePoints.Add(new ObservablePoint
                {
                    X = Frequency[i],
                    Y = Torque[i]
                });
            }

            chrtTorque.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Момент:",
                    Values = ListTorquePoints,
                    LineSmoothness = 1
                }
            };

            chrtTorque.Background = new SolidColorBrush(Colors.Cornsilk);

            chrtTorque.AxisX.Add(new Axis
            {
                Title = "Обороты двигателя",
                FontSize = 20,
                Foreground = new SolidColorBrush(Colors.Black),
                LabelFormatter = value => value + " об/мин"
            });

            chrtTorque.AxisY.Add(new Axis
            {
                Title = "Момент двигателя",
                FontSize = 20,
                Foreground = new SolidColorBrush(Colors.Black),
                LabelFormatter = value => value + " Нм"
            });
            
            #endregion

            for (int i = 0; i < Frequency.Count; i++)
            {
                //chrtTorque.Series["Series1"].Points.AddXY(Frequency[i], Torque[i]);
                chrtConsumption.Series["Series1"].Points.AddXY(Frequency[i], Consumption[i]);
            }
        }

        private void DoSaveExcel()
        {
            using (var context = new MyDbContext())
            {
                using (ExcelPackage MyExcelFile = new ExcelPackage())
                {
                    ExcelWorksheet workSheet = MyExcelFile.Workbook.Worksheets.Add("Worksheet1");

                    workSheet.Cells["A1"].Value = $"Двигатель. {this.Text}";
                    workSheet.Cells["A3"].Value = "id";
                    workSheet.Cells["B3"].Value = "Обороты, об/мин";
                    workSheet.Cells["C3"].Value = "Мощность, кВт";
                    workSheet.Cells["D3"].Value = "Момент, Нм";
                    workSheet.Cells["E3"].Value = "Уд. расход, г/кВтч";

                    workSheet.Cells["A4"].LoadFromCollection(InitialData.DictionaryOfEngines[this.Text]);

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Excel files|*.xlsx|All files|*.*";
                    saveFileDialog1.FileName = "Двигатель. " + this.Text + " " + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                        MyExcelFile.SaveAs(fi);
                    }
                }
            }
        }
    }
}
