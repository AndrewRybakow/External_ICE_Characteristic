using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers

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

            for (int i = 0; i < Frequency.Count; i++)
            {
                chrtPower.Series["Series1"].Points.AddXY(Frequency[i], Power[i]);
                chrtTorque.Series["Series1"].Points.AddXY(Frequency[i], Torque[i]);
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
