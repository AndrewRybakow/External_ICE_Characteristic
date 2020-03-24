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
            try
            {
                GetInitialData();

                LoadingForm loadingForm = new LoadingForm();

                loadingForm.StartPosition = FormStartPosition.CenterParent;

                loadingForm.ShowDialog(this);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверные входные данные. Проверьте ввод!", "Ошибка входных данных",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetInitialData()
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

            InitialData.FrequencyMaxTorque = Convert.ToInt32(txtFrequencyMaxTorque.Text);

            InitialData.FrequencyMaxPower = Convert.ToInt32(txtFrequencyMaxPower.Text);

            InitialData.MaxPower = Convert.ToDouble(txtMaxPower.Text);

            InitialData.MaxTorque = Convert.ToDouble(txtMaxTorque.Text);

            InitialData.TorqueMaxPower = Convert.ToDouble(txtTorqueMaxPower.Text);

            InitialData.MinFConsumption = Convert.ToDouble(txtMinFConsumption.Text);
        }

        private string RandomModelName()
        {
            Random index = new Random();

            string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string Lowercase = "abcdefghijklmnopqrstuvwxyz";
            
            return $"{Uppercase[index.Next(Uppercase.Length)]}{Lowercase[index.Next(Lowercase.Length)]}0{index.Next(99)}{Lowercase[index.Next(Lowercase.Length)]}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        // Validating events

        #region Validating events

            // Step of calculations

        private void txtStep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStep_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateStep(Convert.ToInt32(txtStep.Text), Convert.ToInt32(txtMaxFrequency.Text), Convert.ToInt32(txtMinFrequency.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtStep.Select(0, txtStep.Text.Length);

                    errorProviderMainForm.SetError(txtStep, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtStep.Text = string.Empty;
            }
        }

        private void txtStep_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtStep, string.Empty);
        }

            // Maximum frequency

        private void txtMaxFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaxFrequency_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateMaxFrequency(Convert.ToInt32(txtMaxFrequency.Text), Convert.ToInt32(txtMinFrequency.Text), Convert.ToInt32(txtStep.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtMaxFrequency.Select(0, txtMaxFrequency.Text.Length);

                    errorProviderMainForm.SetError(txtMaxFrequency, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtMaxFrequency.Text = string.Empty;
            }
        }

        private void txtMaxFrequency_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtMaxFrequency, string.Empty);
        }

            // Minimum frequency

        private void txtMinFrequency_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinFrequency_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateMinFrequency(Convert.ToInt32(txtMinFrequency.Text), Convert.ToInt32(txtMaxFrequency.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtMinFrequency.Select(0, txtMinFrequency.Text.Length);

                    errorProviderMainForm.SetError(txtMinFrequency, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtMinFrequency.Text = string.Empty;
            }
        }

        private void txtMinFrequency_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtMinFrequency, string.Empty);
        }

            // Frequency at maximum torque

        private void txtFrequencyMaxTorque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFrequencyMaxTorque_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateFrequencyMaxTorque(Convert.ToDouble(txtFrequencyMaxTorque.Text), Convert.ToInt32(txtMinFrequency.Text), Convert.ToInt32(txtMaxFrequency.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtFrequencyMaxTorque.Select(0, txtFrequencyMaxTorque.Text.Length);

                    errorProviderMainForm.SetError(txtFrequencyMaxTorque, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtFrequencyMaxTorque.Text = string.Empty;
            }
        }

        private void txtFrequencyMaxTorque_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtFrequencyMaxTorque, string.Empty);
        }

            // Frequency at maximum power

        private void txtFrequencyMaxPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFrequencyMaxPower_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateFrequencyMaxPower(Convert.ToInt32(txtFrequencyMaxPower.Text), Convert.ToInt32(txtMinFrequency.Text), Convert.ToInt32(txtMaxFrequency.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtFrequencyMaxPower.Select(0, txtFrequencyMaxPower.Text.Length);

                    errorProviderMainForm.SetError(txtFrequencyMaxPower, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtFrequencyMaxPower.Text = string.Empty;
            }
        }

        private void txtFrequencyMaxPower_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtFrequencyMaxPower, string.Empty);
        }

            // Maximum power
        
        private void txtMaxPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaxPower_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateMaxPower(Convert.ToDouble(txtMaxPower.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtMaxPower.Select(0, txtMaxPower.Text.Length);

                    errorProviderMainForm.SetError(txtMaxPower, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtMaxPower.Text = string.Empty;
            }
        }

        private void txtMaxPower_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtMaxPower, string.Empty);
        }

            // Maximum torque

        private void txtMaxTorque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaxTorque_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateMaxTorque(Convert.ToDouble(txtMaxTorque.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtMaxTorque.Select(0, txtMaxTorque.Text.Length);

                    errorProviderMainForm.SetError(txtMaxTorque, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtMaxTorque.Text = string.Empty;
            }
        }

        private void txtMaxTorque_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtMaxTorque, string.Empty);
        }

            // Torque at maximum power

        private void txtTorqueMaxPower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTorqueMaxPower_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateTorqueMaxPower(Convert.ToDouble(txtTorqueMaxPower.Text), Convert.ToDouble(txtMaxTorque.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtTorqueMaxPower.Select(0, txtTorqueMaxPower.Text.Length);

                    errorProviderMainForm.SetError(txtTorqueMaxPower, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtTorqueMaxPower.Text = string.Empty;
            }
        }

        private void txtTorqueMaxPower_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtTorqueMaxPower, string.Empty);
        }

            // Minimum fuel consumption

        private void txtMinFConsumption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && ((char)Keys.Back != e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMinFConsumption_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (!ValidateMinFConsumption(Convert.ToDouble(txtMinFConsumption.Text), out string errorMessage))
                {
                    e.Cancel = true;
                    txtMinFConsumption.Select(0, txtMinFConsumption.Text.Length);

                    errorProviderMainForm.SetError(txtMinFConsumption, errorMessage);
                }
            }
            catch (FormatException)
            {
                txtMinFConsumption.Text = string.Empty;
            }
        }

        private void txtMinFConsumption_Validated(object sender, EventArgs e)
        {
            errorProviderMainForm.SetError(txtMinFConsumption, string.Empty);
        }

        #endregion

        // Functions to verify initial data

        #region Functions to verify initial data

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
                return false;
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

        #endregion
    }
}
