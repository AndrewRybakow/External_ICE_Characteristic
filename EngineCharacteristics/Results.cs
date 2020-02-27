using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace EngineCharacteristics
{
    public partial class Results : Form
    {

        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            DoCalculations();
            DoGraphs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DoSaveExcel();
        }




        private void DoCalculations()
        {
            Calculations calculations = new Calculations();

            List<double> Frequency;
            List<double> Power;
            List<double> Torque;
            List<double> Consumption;


            double Km = calculations.CalculateKm(InitialData.MaxTorque, InitialData.TorqueMaxPower);
            lblCoefTorque.Text = ("По моменту: " + Km);
            double Kn = calculations.CalculateKn(InitialData.FrequencyMaxPower, InitialData.FrequencyMaxTorque);
            lblCoefFrequency.Text = ("По частоте: " + Kn);

            double a = calculations.CalculateA(Km, Kn);
            lblCoefA.Text = ("a= " + a);
            double b = calculations.CalculateB(Km, Kn);
            lblCoefB.Text = ("b= " + b);
            double c = calculations.CalculateC(Km, Kn);
            lblCoefC.Text = ("c= " + c);
            lblCoefSum.Text = ("Сумма: " + (a + b + c));

            Frequency = calculations.CalculateFrequency(InitialData.MinFrequency, InitialData.MaxFrequency);
            Power = calculations.CalculatePower(InitialData.MaxPower, a, b, c, InitialData.FrequencyMaxPower, Frequency);
            Torque = calculations.CalculateTorque(Power, Frequency);
            Consumption = calculations.CalculateConsumption(InitialData.MinFConsumption, InitialData.FrequencyMaxPower, Frequency);

            using (var context = new MyDbContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [Results]");

                var result = new List<Result>();

                for (int i = 0; i < Frequency.Count; i++)
                {
                    result.Add(new Result()
                    {
                        Frequency = Frequency[i],
                        Power = Power[i],
                        Torque = Torque[i],
                        Consumption = Consumption[i]
                    });
                }

                context.Results.Load();
                context.Results.AddRange(result);
                context.SaveChanges();

                dataGridView1.DataSource = context.Results.Local.ToList();
                this.dataGridView1.Columns["Id"].Visible = false;
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

                    workSheet.Cells["A1"].Value = "id";
                    workSheet.Cells["B1"].Value = "Обороты, об/мин";
                    workSheet.Cells["C1"].Value = "Мощность, кВт";
                    workSheet.Cells["D1"].Value = "Момент, Нм";
                    workSheet.Cells["E1"].Value = "Уд. расход, г/кВтч";

                    workSheet.Cells["A2"].LoadFromCollection(context.Results.ToList());

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Excel files|*.xlsx|All files|*.*";
                    saveFileDialog1.FileName = "Results " + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx";

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
