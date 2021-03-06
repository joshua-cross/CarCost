﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CarCosts
{
    class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Transmission { get; set; }
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public float ElecricEnergyConsumptionMiles { get; set; }
        public float MilesPerKilowatt { get; set; }
        public float MaximumRangeKm { get; set; }
        public float MaximumRangeMiles { get; set; }
        public float MetricUrbanCold { get; set; }
        public float MetricExtraUrban { get; set; }
        public float MetricCombined { get; set; }
        public float ImperialUrbanCold { get; set; }
        public float ImperialExtraUrban { get; set; }
        public float CO2gramsPerKilometer { get; set; }
        public float FuelCostPer12000Miles { get; set; }
        public float ElectricityCost { get; set; }
        public int EuroStandard { get; set; }
        public float NoiseLevelDB { get; set; }
        public float EmissionCO2 { get; set; }
        public float THCLevel { get; set; }
        public float NOxEmissions { get; set; }
        public float THCAndNOxEmissions { get; set; }
        public float Particulates { get; set; }
        public string blank { get; set; }


    }
}