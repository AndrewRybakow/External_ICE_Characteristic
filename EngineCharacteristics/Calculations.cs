using System.Collections.Generic;

namespace EngineCharacteristics
{
    public class Calculations
    {
        public List<double> CalculateFrequency(int MinFrequency, int MaxFrequency, int Step)
        {
            List<double> list = new List<double>();

            for (int i = MinFrequency; i < MaxFrequency + Step; i += Step)
            {
                list.Add(i);
            }

            return list;
        }

        public double CalculateKm(double MaxTorque, double TorqueMaxPower)
        {
            return MaxTorque / TorqueMaxPower;
        }

        public double CalculateKn(double FrequencyMaxPower, double FrequencyMaxTorque)
        {
            return FrequencyMaxPower / FrequencyMaxTorque;
        }

        public double CalculateA(double Km, double Kn)
        {
            return ((Km * Kn * (2 - Kn)) - 1) / ((Kn * (2 - Kn)) - 1);
        }

        public double CalculateB(double Km, double Kn)
        {
            return -((2 * Kn * (Km - 1)) / ((Kn * (2 - Kn)) - 1));
        }

        public double CalculateC(double Km, double Kn)
        {
            return (Kn * Kn * (Km - 1)) / ((Kn * (2 - Kn)) - 1);
        }

        public List<double> CalculatePower(double MaxPower, double a, double b, double c, int FrequencyMaxPower, List<double> frequency)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < frequency.Count; i++)
            {
                list.Add(MaxPower * ((a * (frequency[i] / FrequencyMaxPower)) + (b * System.Math.Pow((frequency[i] / FrequencyMaxPower), 2)) + (c * System.Math.Pow((frequency[i] / FrequencyMaxPower), 3))));
            }

            return list;
        }

        public List<double> CalculateTorque(List<double> power, List<double> frequency)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < frequency.Count; i++)
            {
                list.Add(9550 * (power[i] / frequency[i]));
            }

            return list;
        }

        public List<double> CalculateConsumption(double MinFConsumption, int FrequencyMaxPower, List<double> frequnecy)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < frequnecy.Count; i++)
            {
                list.Add(MinFConsumption * (1.55 - (1.55 * (frequnecy[i] / FrequencyMaxPower)) + System.Math.Pow((frequnecy[i] / FrequencyMaxPower), 2)));
            }

            return list;
        }
    }
}
