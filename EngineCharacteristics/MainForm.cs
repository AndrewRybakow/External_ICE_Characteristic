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
    }
}
