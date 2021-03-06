﻿using System.Collections.Generic;

namespace EngineCharacteristics
{
    static class InitialData
    {
        // Initial data recived from MainForm

        public static string EngineModel { get; set; }

        public static int EngineId { get; set; }

        public static int Step { get; set; }

        public static int MaxFrequency { get; set; }

        public static int MinFrequency { get; set; }

        public static double FrequencyMaxTorque { get; set; }

        public static int FrequencyMaxPower { get; set; }

        public static double MaxPower { get; set; }

        public static double MaxTorque { get; set; }

        public static double TorqueMaxPower { get; set; }

        public static double MinFConsumption { get; set; }

        // Data recived in the process of computing
        
        public static double Km { get; set; }

        public static double Kn { get; set; }

        public static double a { get; set; }

        public static double b { get; set; }

        public static double c { get; set; }

        public static Dictionary<string, List<Result>> DictionaryOfEngines = new Dictionary<string, List<Result>>();
    }
}
