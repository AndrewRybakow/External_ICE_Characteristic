using System;
using System.Windows.Forms;

namespace EngineCharacteristics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtEngineModel.Text == string.Empty)
            {
                InitialData.EngineModel = RandomModelName();
            }
            else
            {
                InitialData.EngineModel = txtEngineModel.Text;
            }

            InitialData.Step = Convert.ToInt32(txtStep.Text);

            InitialData.MaxFrequency = Convert.ToInt32(txtMaxFrequency.Text);

            InitialData.MinFrequency = Convert.ToInt32(txtMinFrequency.Text);

            InitialData.FrequencyMaxTorque = Convert.ToDouble(txtFrequencyMaxTorque.Text);

            InitialData.FrequencyMaxPower = Convert.ToInt32(txtFrequencyMaxPower.Text);

            InitialData.MaxPower = Convert.ToDouble(txtMaxPower.Text);

            InitialData.MaxTorque = Convert.ToDouble(txtMaxTorque.Text);

            InitialData.TorqueMaxPower = Convert.ToDouble(txtTorqueMaxPower.Text);

            InitialData.MinFConsumption = Convert.ToDouble(txtMinFConsumption.Text);

            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
        }
        
        
        private string RandomModelName()
        {
            Random index = new Random();

            string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string Lowercase = "abcdefghijklmnopqrstuvwxyz";
            
            return $"{Uppercase[index.Next(Uppercase.Length)]}{Lowercase[index.Next(Lowercase.Length)]}0{index.Next(99)}{Lowercase[index.Next(Lowercase.Length)]}";
        }


        // Functions to verify initial data
   
        private bool ValidateStep(int step, int maxFrequency, int minFrequency, out string errorMessage)
        {
            if (step <= 0)
            {
                errorMessage = "Шаг расчёта должен быть больше нуля!";
                return false;
            }

            if (step > (maxFrequency - minFrequency))
            {
                errorMessage = "Неверный шаг для данного диапазона частот!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private bool ValidateMaxFrequency(int maxFrequency, int minFrequency, int step, out string errorMessage)
        {
            if (maxFrequency <= 0)
            {
                errorMessage = "Максимальная частота должна быть больше нуля!";
                return false;
            }

            if (maxFrequency < step)
            {
                errorMessage = "Максимальная частота должна быть больше шага расчёта!";
                return false;
            }

            if (maxFrequency < minFrequency)
            {
                errorMessage = "Максимальная частота должна быть больше минимальной!";
            }

            errorMessage = "";
            return true;
        }

        private bool ValidateMinFrequency(int minFrequency, int maxFrequency, out string errorMessage)
        {
            if (minFrequency < 0)
            {
                errorMessage = "Минимальная частота должна быть больше или равна нулю!";
                return false;
            }

            if (minFrequency > maxFrequency)
            {
                errorMessage = "Минимальная частота должна быть меньше максимальной!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private bool ValidateFrequencyMaxTorque(double frequencyMaxTorque, int minFrequency, int maxFrequency, out string errorMessage)
        {
            if (frequencyMaxTorque < 0)
            {
                errorMessage = "Частота при максимальном моменте должна быть положительной!";
                return false;
            }

            if (frequencyMaxTorque < minFrequency)
            {
                errorMessage = "Частота при максимальном моменте должна быть больше минимальной частоты!";
                return false;
            }

            if (frequencyMaxTorque > maxFrequency)
            {
                errorMessage = "Частота при максимальном моменте должна быть меньше максималной частоты!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private bool ValidateFrequencyMaxPower(int frequencyMaxPower, int minFrequency, int maxFrequency, out string errorMessage)
        {
            if (frequencyMaxPower < 0)
            {
                errorMessage = "Частота при максимальной мощности должна быть положительной!";
                return false;
            }

            if (frequencyMaxPower < minFrequency)
            {
                errorMessage = "Частота при максимальной мощности должна быть больше минимальной частоты!";
                return false;
            }

            if (frequencyMaxPower > maxFrequency)
            {
                errorMessage = "Частота при максимальной мощности должна быть меньше максималной частоты!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private bool ValidateMaxPower(double maxPower, out string errorMessage)
        {
            if (maxPower < 0)
            {
                errorMessage = "Максимальная мощность должна быть положительной!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private bool ValidateMaxTorque(double maxTorque, out string errorMessage)
        {
            if (maxTorque < 0)
            {
                errorMessage = "Максимальный момент должен быть положительный!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private bool ValidateTorqueMaxPower(double torqueMaxPower, double maxTorque, out string errorMessage)
        {
            if (torqueMaxPower < 0)
            {
                errorMessage = "Момент при максимальной мощности должен быть положительный!";
                return false;
            }

            if (torqueMaxPower > maxTorque)
            {
                errorMessage = "Момент при максимальной мощности должен быть меньше максимального момента!";
                return false;
            }

            errorMessage = "";
            return true;
        }

        private bool ValidateMinFConsumption(double minFConsumption, out string errorMessage)
        {
            if (minFConsumption <= 0)
            {
                errorMessage = "Минимальный расход топлива должен быть больше нуля!";
                return false;
            }

            errorMessage = "";
            return true;
        }
    }
}
