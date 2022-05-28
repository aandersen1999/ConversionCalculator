using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConversionCalc;

namespace ConversionCalc.Resources
{
    internal static class Formulas
    {
        public delegate Decimal Del(Decimal input);
        public static Del Handler;

        public static void changeFormula(int type1, int type2, int typeConv)
        {
            Handler = null;

            ConversionTypes current = (ConversionTypes)typeConv;
            switch (current)
            {
                case ConversionTypes.Area:
                    Area input1 = (Area)type1;
                    Area input2 = (Area)type2;

                    switch (input1)
                    {
                        case Area.SquareKilometer:
                            switch (input2)
                            {
                                case Area.SquareMeter:
                                    Handler += SqrKToSqrM;
                                    break;
                                case Area.SquareMile:
                                    Handler += SqrKToSqrMi;
                                    break;
                                case Area.SquareYard:
                                    Handler += SqrKToSqrY;
                                    break;
                                case Area.SquareFoot:
                                    Handler += SqrKToSqrF;
                                    break;
                                case Area.SquareInch:
                                    Handler += SqrKToSqrI;
                                    break;
                                case Area.Hectare:
                                    Handler += SqrKToH;
                                    break;
                                case Area.Acre:
                                    Handler += SqrKToA;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Area.SquareMeter:
                            switch (input2)
                            {
                                case Area.SquareKilometer:
                                    Handler += SqrMToSqrKM;
                                    break;
                                case Area.SquareMile:
                                    Handler += SqrMToSqrMi;
                                    break;
                                case Area.SquareYard:
                                    Handler += SqrMToSqrY;
                                    break;
                                case Area.SquareFoot:
                                    Handler += SqrMToSqrF;
                                    break;
                                case Area.SquareInch:
                                    Handler += SqrMToSqrI;
                                    break;
                                case Area.Hectare:
                                    Handler += SqrMToH;
                                    break;
                                case Area.Acre:
                                    Handler += SqrMToA;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case Area.SquareMile:

                            break;
                        case Area.SquareYard:

                            break;
                        case Area.SquareFoot:

                            break;
                        case Area.SquareInch:

                            break;
                        case Area.Hectare:

                            break;
                        case Area.Acre:

                            break;
                    }
                    break;
                case ConversionTypes.DataTransferRate:
                    break;
                case ConversionTypes.DigitalStorage:
                    break;
                case ConversionTypes.Energy:
                    break;
                case ConversionTypes.Frequency:
                    break;
                case ConversionTypes.FuelEconomy:
                    break;
                case ConversionTypes.Length:
                    break;
                case ConversionTypes.Mass:
                    break;
                case ConversionTypes.PlaneAngle:
                    break;
                case ConversionTypes.Pressure:
                    break;
                case ConversionTypes.Speed:
                    break;
                case ConversionTypes.Temperature:
                    break;
                case ConversionTypes.Time:
                    break;
                case ConversionTypes.Volume:
                    break;
                default:
                    break;
            }
        }

        #region Area
        #region SquareKilometers
        private static Decimal SqrKToSqrM(Decimal input)
        {
            Decimal result = input * 1000000;
            return result;
        }
        private static Decimal SqrKToSqrMi(Decimal input)
        {
            Decimal result = input / 2.59m;
            return result;
        }
        private static Decimal SqrKToSqrY(Decimal input)
        {
            Decimal result = input * 1196000;
            return result;
        }
        private static Decimal SqrKToSqrF(Decimal input)
        {
            Decimal result = input * 10760000;
            return result;
        }
        private static Decimal SqrKToSqrI(Decimal input)
        {
            Decimal result = input * 1550000000;
            return result;
        }
        private static Decimal SqrKToH(Decimal input)
        {
            Decimal result = input * 100;
            return result;
        }
        private static Decimal SqrKToA(Decimal input)
        {
            Decimal result = input * 247;
            return result;
        }
        #endregion
        #region SquareMeter
        private static Decimal SqrMToSqrKM(Decimal input)
        {
            Decimal result = input / 1000000;
            return result;
        }
        private static Decimal SqrMToSqrMi(Decimal input)
        {
            Decimal result = input / 2590000;
            return result;
        }
        private static Decimal SqrMToSqrY(Decimal input)
        {
            Decimal result = input * 1.196m;
            return result;
        }
        private static Decimal SqrMToSqrF(Decimal input)
        {
            Decimal result = input * 10.764m;
            return result;
        }
        private static Decimal SqrMToSqrI(Decimal input)
        {
            Decimal result = input * 1550;
            return result;
        }
        private static Decimal SqrMToH(Decimal input)
        {
            Decimal result = input / 10000;
            return result;
        }
        private static Decimal SqrMToA(Decimal input)
        {
            Decimal result = input / 4047;
            return result;
        }
        #endregion
        #endregion
    }
}
