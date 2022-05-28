using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ConversionCalc.Resources
{
    internal class Units
    {
        private static readonly Units instance = new Units();

        private ObservableCollection<string> AreaUnits = new ObservableCollection<string>();
        private ObservableCollection<string> DTRUnits = new ObservableCollection<string>();
        private ObservableCollection<string> DSUnits = new ObservableCollection<string>();
        private ObservableCollection<string> EnergyUnits = new ObservableCollection<string>();
        private ObservableCollection<string> FrequencyUnits = new ObservableCollection<string>();
        private ObservableCollection<string> FuelUnits = new ObservableCollection<string>();
        private ObservableCollection<string> LengthUnits = new ObservableCollection<string>();
        private ObservableCollection<string> MassUnits = new ObservableCollection<string>();
        private ObservableCollection<string> PAUnits = new ObservableCollection<string>();
        private ObservableCollection<string> PressureUnits = new ObservableCollection<string>();
        private ObservableCollection<string> SpeedUnits = new ObservableCollection<string>();
        private ObservableCollection<string> TempUnits = new ObservableCollection<string>();
        private ObservableCollection<string> TimeUnits = new ObservableCollection<string>();
        private ObservableCollection<string> VolumeUnits = new ObservableCollection<string>();

        static Units()
        {
        }
        
        private Units()
        {
            AreaUnitsInit();
        }

        public static Units Instance
        {
            get { return instance; }
        }

        public ObservableCollection<string> GetCollection(int value)
        {
            ConversionTypes currentType = (ConversionTypes)value;

            switch (currentType)
            {
                case ConversionTypes.Area:
                    return AreaUnits;
                default:
                    return null;
            }
        }

        private void AreaUnitsInit()
        {
            AreaUnits.Add(nameof(Area.SquareKilometer));
            AreaUnits.Add(nameof(Area.SquareMeter));
            AreaUnits.Add(nameof(Area.SquareMile));
            AreaUnits.Add(nameof(Area.SquareYard));
            AreaUnits.Add(nameof(Area.SquareFoot));
            AreaUnits.Add(nameof(Area.SquareInch));
            AreaUnits.Add(nameof(Area.Hectare));
            AreaUnits.Add(nameof(Area.Acre));
        }
    }

    internal enum Area : byte
    {
        SquareKilometer,
        SquareMeter,
        SquareMile,
        SquareYard,
        SquareFoot,
        SquareInch,
        Hectare,
        Acre
    }
}
