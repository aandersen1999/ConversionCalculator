using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ConversionCalc.Resources
{
    internal class ConvObject
    {
        private ObservableCollection<string> types = new ObservableCollection<string>();
        public ObservableCollection<string> Types { get { return types; } }

        private const byte TypesCount = 13;
        public ConvObject()
        {
            for (byte i = 0; i <= TypesCount; i++)
            {
                types.Add(GetTypeString(i));
            }
        }

        private string GetTypeString(byte type)
        {
            switch ((ConversionTypes)type)
            {
                case ConversionTypes.Area:
                    return nameof(ConversionTypes.Area);
                case ConversionTypes.DataTransferRate:
                    return nameof(ConversionTypes.DataTransferRate);
                case ConversionTypes.DigitalStorage:
                    return nameof(ConversionTypes.DigitalStorage);
                case ConversionTypes.Energy:
                    return nameof(ConversionTypes.Energy);
                case ConversionTypes.Frequency:
                    return nameof(ConversionTypes.Frequency);
                case ConversionTypes.FuelEconomy:
                    return nameof(ConversionTypes.FuelEconomy);
                case ConversionTypes.Length:
                    return nameof(ConversionTypes.Length);
                case ConversionTypes.Mass:
                    return nameof(ConversionTypes.Mass);
                case ConversionTypes.PlaneAngle:
                    return nameof(ConversionTypes.PlaneAngle);
                case ConversionTypes.Pressure:
                    return nameof(ConversionTypes.Pressure);
                case ConversionTypes.Speed:
                    return nameof(ConversionTypes.Speed);
                case ConversionTypes.Temperature:
                    return nameof(ConversionTypes.Temperature);
                case ConversionTypes.Time:
                    return nameof(ConversionTypes.Time);
                case ConversionTypes.Volume:
                    return nameof(ConversionTypes.Volume);
                default:
                    return "Error";
            }
        }
        private string GetTypeString(ConversionTypes type)
        {
            switch (type)
            {
                case ConversionTypes.Area:
                    return nameof(ConversionTypes.Area);
                case ConversionTypes.DataTransferRate:
                    return nameof(ConversionTypes.DataTransferRate);
                case ConversionTypes.DigitalStorage:
                    return nameof(ConversionTypes.DigitalStorage);
                case ConversionTypes.Energy:
                    return nameof(ConversionTypes.Energy);
                case ConversionTypes.Frequency:
                    return nameof(ConversionTypes.Frequency);
                case ConversionTypes.FuelEconomy:
                    return nameof(ConversionTypes.FuelEconomy);
                case ConversionTypes.Length:
                    return nameof(ConversionTypes.Length);
                case ConversionTypes.Mass:
                    return nameof(ConversionTypes.Mass);
                case ConversionTypes.PlaneAngle:
                    return nameof(ConversionTypes.PlaneAngle);
                case ConversionTypes.Pressure:
                    return nameof(ConversionTypes.Pressure);
                case ConversionTypes.Speed:
                    return nameof(ConversionTypes.Speed);
                case ConversionTypes.Temperature:
                    return nameof(ConversionTypes.Temperature);
                case ConversionTypes.Time:
                    return nameof(ConversionTypes.Time);
                case ConversionTypes.Volume:
                    return nameof(ConversionTypes.Volume);
                default:
                    return "Error";
            }
        }
    }

    internal enum ConversionTypes : byte
    {
        Area,
        DataTransferRate,
        DigitalStorage,
        Energy,
        Frequency,
        FuelEconomy,
        Length,
        Mass,
        PlaneAngle,
        Pressure,
        Speed,
        Temperature,
        Time,
        Volume
    }
}
