using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineCharacteristics
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {

            DoCalcultaions();

            ResultsForm resultsForm = new ResultsForm();
            resultsForm.Show();

            this.Close();
        }

        private void DoCalcultaions()
        {
            Calculations calculations = new Calculations();

            List<double> Frequency;
            List<double> Power;
            List<double> Torque;
            List<double> Consumption;


            InitialData.Km = calculations.CalculateKm(InitialData.MaxTorque, InitialData.TorqueMaxPower);

            InitialData.Kn = calculations.CalculateKn(InitialData.FrequencyMaxPower, InitialData.FrequencyMaxTorque);

            InitialData.a = calculations.CalculateA(InitialData.Km, InitialData.Kn);
            
            InitialData.b = calculations.CalculateB(InitialData.Km, InitialData.Kn);
            
            InitialData.c = calculations.CalculateC(InitialData.Km, InitialData.Kn);
            
            

            Frequency = calculations.CalculateFrequency(InitialData.MinFrequency, InitialData.MaxFrequency);

            Power = calculations.CalculatePower(InitialData.MaxPower, InitialData.a, InitialData.b, InitialData.c, InitialData.FrequencyMaxPower, Frequency);

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

                context.Results.AddRange(result);
                context.SaveChanges();
            }
        }
    }
}
