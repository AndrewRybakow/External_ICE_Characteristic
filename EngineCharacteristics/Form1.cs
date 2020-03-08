using System;
using System.Windows.Forms;

namespace EngineCharacteristics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
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
    }
}
