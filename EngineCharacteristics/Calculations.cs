using System.Collections.Generic;

namespace EngineCharacteristics
{
    public class Calculations
    {
        public List<double> CalculateFrequency(int minFrequency, int maxFrequency, int step)
        {
            List<double> list = new List<double>();

            for (int i = minFrequency; i < maxFrequency + step; i += step)
            {
                list.Add(i);
            }

            return list;
        }

        // Coefficient of engine flexibility by torque

        public double CalculateKm(double maxTorque, double torqueMaxPower)
        {
            return maxTorque / torqueMaxPower;
        }

        // Coefficient of engine flexibility by frequency

        public double CalculateKn(double frequencyMaxPower, double frequencyMaxTorque)
        {
            return frequencyMaxPower / frequencyMaxTorque;
        }

        // Coefficients a, b, c for ICE according to  A. I. Grishkevich

        public double CalculateA(double km, double kn)
        {
            return ((km * kn * (2 - kn)) - 1) / ((kn * (2 - kn)) - 1);
        }

        public double CalculateB(double km, double kn)
        {
            return -((2 * kn * (km - 1)) / ((kn * (2 - kn)) - 1));
        }

        public double CalculateC(double km, double kn)
        {
            return (kn * kn * (km - 1)) / ((kn * (2 - kn)) - 1);
        }

        // Power calculations are based on Leideman’s formula for ICE

        public List<double> CalculatePower(double maxPower, double a, double b, double c, int frequencyMaxPower, List<double> frequency)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < frequency.Count; i++)
            {
                list.Add(maxPower * ((a * (frequency[i] / frequencyMaxPower)) + (b * System.Math.Pow((frequency[i] / frequencyMaxPower), 2)) + (c * System.Math.Pow((frequency[i] / frequencyMaxPower), 3))));
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

        public List<double> CalculateConsumption(double minFConsumption, int frequencyMaxPower, List<double> frequnecy)
        {
            List<double> list = new List<double>();
            for (int i = 0; i < frequnecy.Count; i++)
            {
                list.Add(minFConsumption * (1.55 - (1.55 * (frequnecy[i] / frequencyMaxPower)) + System.Math.Pow((frequnecy[i] / frequencyMaxPower), 2)));
            }

            return list;
        }
    }
}
