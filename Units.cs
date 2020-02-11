using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Units
{
    public static class Units
    {
        
        /// <summary>
        /// Unit enumerator containing all units and additional needed information (realized as attribute)
        /// </summary>
        public enum UnitNamesEnum
        {
            #region Unkown Unit
            [Symbol("?"), BaseUnit("Unknown"), LongName("unknown")]
            [UnitCategory(UnitCategory.Unknown), UnitSystem(UnitSystem.None)]
            [Conversion(double.NaN, double.NaN)]
            Unknown,
            #endregion

            #region Unity
            [Symbol("1"), BaseUnit("Unity"), LongName("unity")]
            [UnitCategory(UnitCategory.Unity), UnitSystem(UnitSystem.Unity)]
            [Conversion(0d, 1d)]
            Unity,
            #endregion

            #region Length
            [Symbol("m"), BaseUnit("Meter"), LongName("meter")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            Meter,

            [Symbol("km"), BaseUnit("Meter"), LongName("kilometer")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-3)]
            Kilometer,

            [Symbol("dm"), BaseUnit("Meter"), LongName("decimeter")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e1)]
            Decimeter,

            [Symbol("cm"), BaseUnit("Meter"), LongName("centimeter")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e2)]
            Centimeter,

            [Symbol("mm"), BaseUnit("Meter"), LongName("millimeter")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            Millimeter,

            [Symbol("µm"), BaseUnit("Meter"), LongName("micrometer")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            Micrometer,

            [Symbol("nm"), BaseUnit("Meter"), LongName("nanometer")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9)]
            Nanometer,

            [Symbol("mi"), BaseUnit("Meter"), LongName("mile")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 1609.344d)]
            Mile,

            [Symbol("yd"), BaseUnit("Meter"), LongName("yard")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.9144d)]
            Yard,

            [Symbol("ft"), BaseUnit("Meter"), LongName("foot")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.3048d)]
            Foot,

            [Symbol("in"), BaseUnit("Meter"), LongName("inch")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 2.54e-2)]
            Inch,

            [Symbol("mil"), BaseUnit("Meter"), LongName("mil")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 2.54e-5)]
            Mil,

            [Symbol("µin"), BaseUnit("Meter"), LongName("microinch")]
            [UnitCategory(UnitCategory.Length), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 2.54e-8)]
            Microinch,
            #endregion

            #region Areal
            [Symbol("m²", "m^2"), BaseUnit("SquareMeter"), LongName("square meter")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            SquareMeter,

            [Symbol("mm²", "mm^2"), BaseUnit("SquareMeter"), LongName("square millimeter")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-6)]
            SquareMillimeter,

            [Symbol("cm²", "cm^2"), BaseUnit("SquareMeter"), LongName("square centimeter")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-4)]
            SquareCentimeter,

            [Symbol("dm²", "dm^2"), BaseUnit("SquareMeter"), LongName("square decimeter")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-2)]
            SquareDecimeter,

            [Symbol("km²", "km^2"), BaseUnit("SquareMeter"), LongName("square kilometer")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            SquareKilometer,

            [Symbol("ha"), BaseUnit("SquareMeter"), LongName("hector")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e4)]
            Hectar,

            [Symbol("mi²", "mi^2"), BaseUnit("SquareMeter"), LongName("square mile")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 2589988.110336d)]
            SquareMile,

            [Symbol("yd²", "yd^2"), BaseUnit("SquareMeter"), LongName("square yard")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.83612736d)]
            SquareYard,

            [Symbol("ft²", "ft^2"), BaseUnit("SquareMeter"), LongName("sqaure foot")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.83612736d)]
            SquareFoot,

            [Symbol("in²", "in^2"), BaseUnit("SquareMeter"), LongName("square inch")]
            [UnitCategory(UnitCategory.Areal), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.83612736d)]
            SquareInch,
            #endregion

            #region Volume
            //SI
            [Symbol("m³", "m^3"), BaseUnit("CubicMeter"), LongName("cubic meter")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            CubicMeter,

            [Symbol("mm³", "mm^3"), BaseUnit("CubicMeter"), LongName("cubic millimeter")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-9)]
            CubicMillimeter,

            [Symbol("cm³", "cm^3"), BaseUnit("CubicMeter"), LongName("cubic centimeter")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d,1e-6)]
            CubicCentimeter,

            [Symbol("dm³", "dm^3"), BaseUnit("CubicMeter"), LongName("cubic decimeter")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d,1e-3)]
            CubicDecimeter,

            [Symbol("km³", "km^3"), BaseUnit("CubicMeter"), LongName("cubic kilometer")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d,1e9)]
            CubicKilometer,

            // Liter
            [Symbol("ml") , BaseUnit("CubicMeter"), LongName("milliliter") ]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d,1e-6)]
            Milliliter,

            [Symbol("cl"), BaseUnit("CubicMeter"), LongName("centiliter")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-5)]
            Centiliter,

            [Symbol("dl") , BaseUnit("CubicMeter"), LongName("decileter")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d,1e-4)]
            Deciliter,

            [Symbol("l"), BaseUnit("CubicMeter"), LongName("liter")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d,1e-3)]
            Liter,

            [Symbol("hl"), BaseUnit("CubicMeter"), LongName("hectolieter")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d,1e-1)]
            Hectoliter,

            //
            [Symbol("ft³", "ft^3"), BaseUnit("CubicMeter"), LongName("cubic foot")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.0283168d)]
            CubicFoot,

            [Symbol("in³", "in^3"), BaseUnit("CubicMeter"), LongName("cubi inch")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 1.6387 * 1e-5)]
            CubicInch,

            [Symbol("mi³", "mi^3"), BaseUnit("CubicMeter"), LongName("cubi mile")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 4.16818183 * 1e9)]
            CubicMile,

            [Symbol("yd³", "yd^3"), BaseUnit("CubicMeter"), LongName("cubic yard")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.764554858d)]
            CubicYard,

            [Symbol("gal (imp.)"), BaseUnit("CubicMeter"), LongName("imperial gallon")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.Imperial)]
            [Conversion(0d, 0.00454609000000181429905810072407d)]
            ImperialGallon,

            [Symbol("oz (imp.)"), BaseUnit("CubicMeter"), LongName("imperial ounze") ]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.Imperial)]
            [Conversion(0d, 2.8413062499962901241875439064617e-5)]
            ImperialOunce,

            [Symbol("gal (U.S.)"), BaseUnit("CubicMeter"), LongName("gallon") ]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.US)]
            [Conversion(0d, 0.00378541d)]
            UsGallon,

            [Symbol("oz (U.S.)"), BaseUnit("CubicMeter"), LongName("ounze")]
            [UnitCategory(UnitCategory.Volume), UnitSystem(UnitSystem.US)]
            [Conversion(0d, 2.957352956253760505068307980135 * 1e-5)]
            UsOunce,
            #endregion

            #region Mass
            [Symbol("kg"), BaseUnit("Kilogram"), LongName("kilogram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            Kilogram,

            [Symbol("Mt"), BaseUnit("Kilogram"), LongName("megaton") ]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9)]
            Megaton,

            [Symbol("kt"), BaseUnit("Kilogram"), LongName("kiloton")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            Kiloton,

            [Symbol("t") , BaseUnit("Kilogram"), LongName("ton")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            Ton,

            [Symbol("hg"), BaseUnit("Kilogram"), LongName("hectogram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-1)]
            Hectogram,

            [Symbol("dag") , BaseUnit("Kilogram"), LongName("decagram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-2)]
            Decagram,

            [Symbol("g"), BaseUnit("Kilogram"), LongName("gram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-3)]
            Gram,

            [Symbol("dg") , BaseUnit("Kilogram"), LongName("decigram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-4)]
            Decigram,

            [Symbol("cg"), BaseUnit("Kilogram"), LongName("centigram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-5)]
            Centigram,

            [Symbol("mg"), BaseUnit("Kilogram"), LongName("milligram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-6)]
            Milligram,

            [Symbol("µg"), BaseUnit("Kilogram"), LongName("micrgram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-9)]
            Microgram,

            [Symbol("ng"), BaseUnit("Kilogram"), LongName("nanogram")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-12)]
            Nanogram,

            [Symbol("short tn"), BaseUnit("Kilogram"), LongName("short ton")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.US)]
            [Conversion(0d, 907.18474)]
            /// <summary>
            ///     The short ton is a unit of mass equal to 2,000 pounds (907.18474 kg), that is most commonly used in the United States – known there simply as the ton.
            /// </summary>
            /// <remarks>http://en.wikipedia.org/wiki/Short_ton</remarks>
            ShortTon,

            [Symbol("lb"), BaseUnit("Kilogram"), LongName("pound")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.45359237)]
            /// <summary>
            ///     The pound or pound-mass (abbreviations: lb, lbm) is a unit of mass used in the imperial, United States customary and other systems of measurement. A number of different definitions have been used, the most common today being the international avoirdupois pound which is legally defined as exactly 0.45359237 kilograms, and which is divided into 16 avoirdupois ounces.
            /// </summary>
            Pound,

            [Symbol("long tn"), BaseUnit("Kilogram"), LongName("long ton")]
            [UnitCategory(UnitCategory.Mass), UnitSystem(UnitSystem.Imperial)]
            [Conversion(0d, 1016.0469088)]
            /// <summary>
            ///     Long ton (weight ton or Imperial ton) is a unit of mass equal to 2,240 pounds (1,016 kg) and is the name for the unit called the "ton" in the avoirdupois or Imperial system of measurements that was used in the United Kingdom and several other Commonwealth countries before metrication.
            /// </summary>
            /// <remarks>http://en.wikipedia.org/wiki/Long_ton</remarks>
            LongTon,
            #endregion

            #region Veloctiy
            [Symbol("m/s"), BaseUnit("MeterPerSeconds"), LongName("meter per second")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            MeterPerSeconds,

            [Symbol("m/min"), BaseUnit("MeterPerSeconds"), LongName("meter per minute")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d /60d)]
            MeterPerMinutes,

            [Symbol("m/h"), BaseUnit("MeterPerSeconds"), LongName("meter per hour")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d/3600d)]
            MeterPerHour,

            [Symbol("mm/s"), BaseUnit("MeterPerSeconds"), LongName("millimeter per second")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1000d)]
            MilliMeterPerSeconds,

            [Symbol("mm/min"), BaseUnit("MeterPerSeconds"), LongName("millimeter per minute")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1000d / 60d)]
            MilliMeterPerMinutes,

            [Symbol("mm/h"), BaseUnit("MeterPerSeconds"), LongName("millimeter per hour")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1000d / 3600d)]
            MilliMeterPerHour,
            
            [Symbol("cm/s"), BaseUnit("MeterPerSeconds"), LongName("centimeter per second")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 100d)]
            CentiMeterPerSeconds,
            
            [Symbol("cm/min"), BaseUnit("MeterPerSeconds"), LongName("centimeter per minute")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 100d / 60d)]
            CentiMeterPerMinutes,

            [Symbol("cm/h"), BaseUnit("MeterPerSeconds"), LongName("centimeter per hour")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 100d / 3600d)]
            CentiMeterPerHour,
            
            [Symbol("km/s"), BaseUnit("MeterPerSeconds"), LongName("kilometer per second")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1000d)]
            KilometerPerSecond,

            [Symbol("km/min"), BaseUnit("MeterPerSeconds"), LongName("kilometer per minute")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1000d/60d)]
            KilometerPerMinute,

            [Symbol("km/h"), BaseUnit("MeterPerSeconds"), LongName("kilometer per hour")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 3.6d)]
            KilometerPerHour,

            [Symbol("ft/s"), BaseUnit("MeterPerSeconds"), LongName("foot per second")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.3048d)]
            FootPerSecond,

            [Symbol("ft/min"), BaseUnit("MeterPerSeconds"), LongName("foot per minute")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.3048d / 60d)]
            FootPerMinute,

            [Symbol("ft/h"), BaseUnit("MeterPerSeconds"), LongName("foot per hour")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.3048d / 3600d)]
            FootPerHour,

            [Symbol("knot"), BaseUnit("MeterPerSeconds"), LongName("knot")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.514444d)]
            Knot,

            [Symbol("mps", "mi/s"), BaseUnit("MeterPerSeconds"), LongName("mile per second")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.44704d / 3600d)]
            MilePerSecond,

            [Symbol("mpmin", "mi/min"), BaseUnit("MeterPerSeconds"), LongName("mile per minute")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.44704d / 60d)]
            MilePerMinute,

            [Symbol("mph", "mi/h"), BaseUnit("MeterPerSeconds"), LongName("mile per hour")]
            [UnitCategory(UnitCategory.Velocity), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.44704d)]
            MilePerHour,
            #endregion

            #region Pressure
            [Symbol("Pa"), BaseUnit("Pascal"), LongName("pascal")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            Pascal,

            [Symbol("hPa"), BaseUnit("Pascal"), LongName("hectopascal")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 100d)]
            HectoPascal,

            [Symbol("kPa"), BaseUnit("Pascal"), LongName("kilopascal")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            Kilopascal,

            [Symbol("MPa"), BaseUnit("Pascal"), LongName("megapascal")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            Megapascal,

            [Symbol("bar", "Bar"), BaseUnit("Pascal"), LongName("bar")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e5)]
            Bar,

            [Symbol("mbar", "mBar"), BaseUnit("Pascal"), LongName("millibar")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e2)]
            MilliBar,

            [Symbol("N/m²", "N/m^2"), BaseUnit("Pascal"), LongName("newton per square meter")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            NewtonPerSquareMeter,

            [Symbol("N/cm²", "N/cm^2"), BaseUnit("Pascal"), LongName("newton per square centimeter")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e4)]
            NewtonPerSquareCentimeter,

            [Symbol("N/mm²", "N/mm^2"), BaseUnit("Pascal"), LongName("newton per square millimeter")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            NewtonPerSquareMillimeter,

            [Symbol("atm"), BaseUnit("Pascal"), LongName("atmosphere")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 101325d)]
            Atmosphere,

            [Symbol("kgf/cm²", "kgf/cm^2"), BaseUnit("Pascal"), LongName("kilogram force per square centimeter")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 9.80665e4)]
            KilogramForcePerSquareCentimeter,

            [Symbol("psi"), BaseUnit("Pascal"), LongName("pound per square inch")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 6.89464975179e3)]
            Psi,

            [Symbol("at"), BaseUnit("Pascal"), LongName("tecnical atmosphere")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 9.80680592331e4)]
            TechnicalAtmosphere,

            [Symbol("torr", "mmHg"), BaseUnit("Pascal"), LongName("torr")]
            [UnitCategory(UnitCategory.Pressure), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, (101325d / 760d))]
            Torr,
            #endregion

            #region Frequency
            [Symbol("Hz"), BaseUnit("Hertz"), LongName("hertz")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1)]
            Hertz,

            [Symbol("THz"), BaseUnit("Hertz"), LongName("teraherz")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-9)]
            TeraHerz,

            [Symbol("MHz"), BaseUnit("Hertz"), LongName("megahertz")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-6)]
            MegaHertz,

            [Symbol("kHz"), BaseUnit("Hertz"), LongName("kilohert")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e-3)]
            KiloHertz,

            [Symbol("mHz"), BaseUnit("Hertz"), LongName("millihertz") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            MilliHertz,

            [Symbol("µHz"), BaseUnit("Hertz"), LongName("microhertz")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            MicroHertz,

            [Symbol("cph"), BaseUnit("Hertz"), LongName("cylces per hour")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 3600d)]
            CyclesPerHour,

            [Symbol("cpd") , BaseUnit("Hertz"), LongName("cycles per day")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 86400d)]
            CyclesPerDay,

            [Symbol("°/s", "degree/s"), BaseUnit("Hertz"), LongName("degree per second")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 360d)]
            DegreePerSecond,

            [Symbol("°/min", "degree/min"), BaseUnit("Hertz"), LongName("degree per minute")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 21600d)]
            DegreePerMinute,

            [Symbol("°/h", "degree/h"), BaseUnit("Hertz"), LongName("degree per hour")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1296000d)]
            DegreePerHour,

            [Symbol("°/d", "degree/d") , BaseUnit("Hertz"), LongName("degree per day")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 31104000d)]
            DegreePerDay,

            [Symbol("rad/s") ,BaseUnit("Hertz"), LongName("radian per second")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI * 2d)]
            RadianPerSecond,

            [Symbol("mrad/s"), BaseUnit("Hertz"), LongName("milliradian per second") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI * 2e3)]
            MilliRadianPerSecond,

            [Symbol("µrad/s"), BaseUnit("Hertz"), LongName("microradian per second") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI * 2e6)]
            MicroRadianPerSecond,

            [Symbol("nrad/s"), BaseUnit("Hertz"), LongName("nanoradian per second") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI * 2e9)]
            NanoRadianPerSecond,

            [Symbol("prad/s"), BaseUnit("Hertz"), LongName("picoradian per second")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI * 2e12)]
            PicoRadianPerSecond,

            [Symbol("rad/min"), BaseUnit("Hertz"), LongName("radian per minute") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI * 2d * 60d)]
            RadianPerMinute,

            [Symbol("rad/h"), BaseUnit("Hertz"), LongName("radian per hour") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI * 2d * 3600d)]
            RadiansPerHour,

            [Symbol("rad/d") , BaseUnit("Hertz"), LongName("radian per day") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI * 2d * 86400d)]
            RadianPerDay,

            [Symbol("RPS") , BaseUnit("Hertz"), LongName("revolution per second")]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 1d)]
            RevolutionPerSecond,

            [Symbol("RPM"),  BaseUnit("Hertz"), LongName("revolution per minute") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 60d)]
            RevolutionPerMinute,

            [Symbol("RPH") , BaseUnit("Hertz"), LongName("revolution per hour") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 3600d)]
            RevolutionPerHour,

            [Symbol("RPD") , BaseUnit("Hertz"), LongName("revolution per day") ]
            [UnitCategory(UnitCategory.Frequency), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 86400d)]
            RevolutionPerDay,
            #endregion

            #region Gravity / Acceleration
            [Symbol("m/s²", "m/s^2"), BaseUnit("MeterPerSecondSquared"), LongName("meter per second squared")]
            [UnitCategory(UnitCategory.Gravity), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            MeterPerSecondSquared,

            [Symbol("mm/s²", "mm/s^2"), BaseUnit("MeterPerSecondSquared"), LongName("millimeter per second squared")]
            [UnitCategory(UnitCategory.Gravity), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            MilliMeterPerSecondSquared,

            [Symbol("µm/s²", "µm/s^2"), BaseUnit("MeterPerSecondSquared"), LongName("micrometer per second squared")]
            [UnitCategory(UnitCategory.Gravity), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            MicroMeterPerSecondSquared,

            [Symbol("nm/s²", "nm/s^2"), BaseUnit("MeterPerSecondSquared"), LongName("nanometer per second squared")]
            [UnitCategory(UnitCategory.Gravity), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9)]
            NanoMeterPerSecondSquared,

            [Symbol("Gal"), BaseUnit("MeterPerSecondSquared"), LongName("gal")]
            [UnitCategory(UnitCategory.Gravity), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 1e2)]
            Gal,

            [Symbol("mGal"), BaseUnit("MeterPerSecondSquared"), LongName("milligal")]
            [UnitCategory(UnitCategory.Gravity), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e5)]
            MilliGal,

            [Symbol("µGal"), BaseUnit("MeterPerSecondSquared"), LongName("microgal")]
            [UnitCategory(UnitCategory.Gravity), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e8)]
            MicroGal,
            #endregion

            #region Gravity change
            [Symbol("m/s²/s", "m/s^2/s"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("meter per second squared per second")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            MeterPerSecondSquaredPerSecond,

            [Symbol("mm/s²/s", "mm/s^2/s"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("millimeter per second squared per second")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            MilliMeterPerSecondSquaredPerSecond,

            [Symbol("µm/s²/s", "µm/s^2/s"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("micrometer per second squared per second")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            MicroMeterPerSecondSquaredPerSecond,

            [Symbol("nm/s²/s", "nm/s^2/s"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("nanometer per second squared per second")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9)]
            NanoMeterPerSecondSquaredPerSecond,

            [Symbol("Gal/s"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("gal per second")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 1e2)]
            GalPerSecond,

            [Symbol("mGal/s"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("milligal per second")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e5)]
            MilliGalPerSecond,

            [Symbol("µGal/s"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("microgal per second")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e8)]
            MicroGalPerSecond,

            [Symbol("m/s²/min", "m/s^2/min"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("meter per second squared per minute")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d/60d)]
            MeterPerSecondSquaredPerMinute,

            [Symbol("mm/s²/min", "mm/s^2/min"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("millimeter per second squared per minute")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3/60d)]
            MilliMeterPerSecondSquaredPerMinute,

            [Symbol("µm/s²/min", "µm/s^2/min"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("micrometer per second squared per minute")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6 / 60d)]
            MicroMeterPerSecondSquaredPerMinute,

            [Symbol("nm/s²/min", "nm/s^2/min"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("nanometer per second squared per minute")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9 / 60d)]
            NanoMeterPerSecondSquaredPerMinute,

            [Symbol("Gal/min"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("gal per minute")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 1e2 / 60d)]
            GalPerMinute,

            [Symbol("mGal/min"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("milligal per minute")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e5 / 60d)]
            MilliGalPerMinute,

            [Symbol("µGal/min"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("microgal per minute")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e8 / 60d)]
            MicroGalPerMinute,

            [Symbol("m/s²/h", "m/s^2/h"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("meter per second squared per hour")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d / 3600d)]
            MeterPerSecondSquaredPerHour,

            [Symbol("mm/s²/h", "mm/s^2/h"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("millimeter per second squared per hour")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3 / 3600d)]
            MilliMeterPerSecondSquaredPerHour,

            [Symbol("µm/s²/h", "µm/s^2/h"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("micrometer per second squared per hour")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6 / 3600d)]
            MicroMeterPerSecondSquaredPerHour,

            [Symbol("nm/s²/h", "nm/s^2/h"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("nanometer per second squared per hour")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9 / 3600d)]
            NanoMeterPerSecondSquaredPerHour,

            [Symbol("Gal/h"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("gal per hour")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 1e2 / 3600d)]
            GalPerHour,

            [Symbol("mGal/h"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("milligal per hour")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e5 / 3600d)]
            MilliGalPerHour,

            [Symbol("µGal/h"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("microgal per hour")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e8 / 3600d)]
            MicroGalPerHour,

            [Symbol("m/s²/d", "m/s^2/d"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("meter per second squared per day")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d / 86400d)]
            MeterPerSecondSquaredPerDay,

            [Symbol("mm/s²/d", "mm/s^2/d"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("millimeter per second squared per day")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3 / 86400d)]
            MilliMeterPerSecondSquaredPerDay,

            [Symbol("µm/s²/d", "µm/s^2/d"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("micrometer per second squared per day")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6 / 86400d)]
            MicroMeterPerSecondSquaredPerDay,

            [Symbol("nm/s²/d", "nm/s^2/d"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("nanometer per second squared per day")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9 / 86400d)]
            NanoMeterPerSecondSquaredPerDay,

            [Symbol("Gal/d"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("gal per day")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 1e2 / 86400d)]
            GalPerDay,

            [Symbol("mGal/d"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("milligal per day")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e5 / 86400d)]
            MilliGalPerDay,

            [Symbol("µGal/d"), BaseUnit("MeterPerSecondSquaredPerSecond"), LongName("microgal per day")]
            [UnitCategory(UnitCategory.GravityChange), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e8 / 86400d)]
            MicroGalPerDay,
            #endregion

            #region Gravity gradient
            [Symbol("m/s²/m", "m/s^2/m"), BaseUnit("MeterPerSecondSquared"), LongName("meter per second squared per meter")]
            [UnitCategory(UnitCategory.GravityGradient), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            MeterPerSecondSquaredPerMeter,

            [Symbol("mm/s²/m", "mm/s^2/m"), BaseUnit("MeterPerSecondSquared"), LongName("millimeter per second squared per meter")]
            [UnitCategory(UnitCategory.GravityGradient), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            MilliMeterPerSecondSquaredPerMeter,

            [Symbol("µm/s²/m", "µm/s^2/m"), BaseUnit("MeterPerSecondSquared"), LongName("micrometer per second squared per meter")]
            [UnitCategory(UnitCategory.GravityGradient), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            MicroMeterPerSecondSquaredPerMeter,

            [Symbol("nm/s²/m", "nm/s^2/m"), BaseUnit("MeterPerSecondSquared"), LongName("nanometer per second squared per meter")]
            [UnitCategory(UnitCategory.GravityGradient), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9)]
            NanoMeterPerSecondSquaredPerMeter,

            [Symbol("Gal/m"), BaseUnit("MeterPerSecondSquared"), LongName("gal per meter")]
            [UnitCategory(UnitCategory.GravityGradient), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 1e2)]
            GalPerMeter,

            [Symbol("mGal/m"), BaseUnit("MeterPerSecondSquared"), LongName("milligal per meter")]
            [UnitCategory(UnitCategory.GravityGradient), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e5)]
            MilliGalPerMeter,

            [Symbol("µGal/m"), BaseUnit("MeterPerSecondSquared"), LongName("microgal per meter")]
            [UnitCategory(UnitCategory.GravityGradient), UnitSystem(UnitSystem.CGS_NotCoherent)]
            [Conversion(0d, 1e8)]
            MicroGalPerMeter,
            #endregion

            #region Angle
            [Symbol("deg"), BaseUnit("Degree"), LongName("degree")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            Degree,

            [Symbol("gon"), BaseUnit("Degree"), LongName("gradian")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 0.9d)]
            Gradian,

            [Symbol("arcmin"), BaseUnit("Degree"), LongName("arxminute")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 60d)]
            ArcMinute,

            [Symbol("arcsec"), BaseUnit("Degree"), LongName("arcsecond")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 3600d)]
            ArcSecond,

            [Symbol("mas"), BaseUnit("Degree"), LongName("milliarcsecond")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 3600000d)]
            MilliArcSecond,

            [Symbol("µas"), BaseUnit("Degree"), LongName("microarcsecond")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 3600000000d)]
            MicroArcSecond,

            [Symbol("rad"), BaseUnit("Degree"), LongName("radian")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, Math.PI / 180d)]
            Radian,

            [Symbol("mrad"), BaseUnit("Degree"), LongName("milliradian")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI / 180d * 1000d)]
            MilliRadian,

            [Symbol("µrad"), BaseUnit("Degree"), LongName("microradian")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI / 180d * 1000000d)]
            MicroRadian,

            [Symbol("nrad"), BaseUnit("Degree"), LongName("nanoradian")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI / 180d * 1000000000d)]
            NanoRadian,

            [Symbol("prad"), BaseUnit("Degree"), LongName("picoradian")]
            [UnitCategory(UnitCategory.Angle), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, Math.PI / 180d * 1000000000000d)]
            PicoRadian,

            #endregion

            #region Angular Acceleration

            [Symbol("rad/s²", "rad/s^2"), BaseUnit("Angular acceleration"), LongName("radian per second squared")]
            [UnitCategory(UnitCategory.AngularAcceleration), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            RadianPerSecondSquared,

            [Symbol("mrad/s²", "mrad/s^2"), BaseUnit("Angular acceleration"), LongName("milli radian per second squared")]
            [UnitCategory(UnitCategory.AngularAcceleration), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            MilliRadianPerSecondSquared,

            [Symbol("µrad/s²", "µrad/s^2"), BaseUnit("Angular acceleration"), LongName("micro radian per second squared")]
            [UnitCategory(UnitCategory.AngularAcceleration), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e6)]
            MicroRadianPerSecondSquared,

            [Symbol("nrad/s²", "nrad/s^2"), BaseUnit("Angular acceleration"), LongName("nano radian per second squared")]
            [UnitCategory(UnitCategory.AngularAcceleration), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e9)]
            NanoRadianPerSecondSquared,

            [Symbol("prad/s²", "prad/s^2"), BaseUnit("Angular acceleration"), LongName("pico radian per second squared")]
            [UnitCategory(UnitCategory.AngularAcceleration), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e12)]
            PicoRadianPerSecondSquared,

            [Symbol("°/s²", "deg/s²", "degree/s²", "°/s^2", "deg/s^2", "degree/s^2"), BaseUnit("Angular acceleration"), LongName("degree per second squared")]
            [UnitCategory(UnitCategory.AngularAcceleration), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 180d / Math.PI)]
            DegreePerSecondSquared,

            #endregion

            #region Temperature
            [Symbol("°C"), BaseUnit("Kelvin"), LongName("degree Celsius")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(273.15d, 1d)]
            DegreeCelsius,

            [Symbol("°De"), BaseUnit("Kelvin"), LongName("degree Delisle")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.Historic)]
            [Conversion(373.15d, -2d / 3d)]
            DegreeDelisle,

            [Symbol("°F"), BaseUnit("Kelvin"), LongName("degree Fahrenheit")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.US)]
            [Conversion(459.67d * 5d / 9d, 5d / 9)]
            DegreeFahrenheit,

            [Symbol("K"), BaseUnit("Kelvin"), LongName("Kelvin")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            Kelvin,

            [Symbol("mK"), BaseUnit("Kelvin"), LongName("Kelvin")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1000d)]
            MilliKelvin,


            [Symbol("°N"), BaseUnit("Kelvin"), LongName("degree Newton")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.Historic)]
            [Conversion(273.15d, 100d / 33d)]
            DegreeNewton,

            [Symbol("°R"), BaseUnit("Kelvin"), LongName("degree Rankine")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.US)]
            [Conversion(0d, 5d / 9d)]
            DegreeRankine,

            [Symbol("°Ré"), BaseUnit("Kelvin"), LongName("degree Reaumur")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.Historic)]
            [Conversion(273.15d, 5d / 4)]
            DegreeReaumur,

            [Symbol("°Rø"), BaseUnit("Kelvin"), LongName("degree Römer")]
            [UnitCategory(UnitCategory.Temperature), UnitSystem(UnitSystem.None)]
            [Conversion(273.15d - 7.5d * 40d / 21d, 40d / 21d)]
            DegreeRoemer,
            #endregion

            #region Strain
            [Symbol("strain", "m/m"), BaseUnit("Strain"), LongName("strain")]
            [UnitCategory(UnitCategory.Strain), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1)]
            Strain,

            [Symbol("mstrain", "mm/m"), BaseUnit("Strain"), LongName("millistrain")]
            [UnitCategory(UnitCategory.Strain), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e3)]
            MilliStrain,

            [Symbol("µstrain", "µm/m"), BaseUnit("Strain"), LongName("microstrain")]
            [UnitCategory(UnitCategory.Strain), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e6)]
            MicroStrain,

            [Symbol("nstrain", "nm/m"), BaseUnit("Strain"), LongName("nanostrain") ]
            [UnitCategory(UnitCategory.Strain), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1e9)]
            NanoStrain,
            #endregion

            #region ElectricPotential
            [Symbol("V", "Volt", "W/A", "J/C", "m²·kg·s¯³·A¯¹", "Nm·A¯¹·s¯¹", "m^2·kg·s^-3·A^-1", "Nm·A^-1·s^-1"), BaseUnit("Voltage"), LongName("voltage")]
            [UnitCategory(UnitCategory.ElectricPotential), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Voltage,

            [Symbol("µV"), BaseUnit("Voltage"), LongName("microvoltage")]
            [UnitCategory(UnitCategory.ElectricPotential), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e6)]
            MicroVoltage,

            [Symbol("mV"), BaseUnit("Voltage"), LongName("millivoltage")]
            [UnitCategory(UnitCategory.ElectricPotential), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            MilliVoltage,
            
            [Symbol("kV"), BaseUnit("Voltage"), LongName("kilovaoltage")]
            [UnitCategory(UnitCategory.ElectricPotential), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e-3)]
            KiloVoltage,
            #endregion

            #region Force
            [Symbol("N", "m·kg·s¯²", "m·kg·s^2"), BaseUnit("Newton"), LongName("newton")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Newton,

            [Symbol("kN"), BaseUnit("Newton"), LongName("kilonewton")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            KiloNewton,

            [Symbol("MN"), BaseUnit("Newton"), LongName("meganewton")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            MegaNewton,

            [Symbol("dyn", "g·cm/s²", "g·cm/s^2"), BaseUnit("Newton"), LongName("dyn")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 1e-5)]
            Dyn,

            [Symbol("p"), BaseUnit("Newton"), LongName("pond")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 9.80665002864e-3)]
            Pond,

            [Symbol("kp"), BaseUnit("Newton"), LongName("kilopond")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 9.80665002864)]
            KiloPond,

            [Symbol("kgf"), BaseUnit("Newton"), LongName("kilogram force")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 9.80665002864)]
            KilogramForce,

            [Symbol("pdl"), BaseUnit("Newton"), LongName("poundal")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 0.13825502798973041652092282466083)]
            Poundal,

            [Symbol("lbf"), BaseUnit("Newton"), LongName("pound force")]
            [UnitCategory(UnitCategory.Force), UnitSystem(UnitSystem.US_Imperial)]
            [Conversion(0d, 4.4482216152605095551842641431421)]
            PoundForce,
            #endregion

            #region Flow
            [Symbol("m³/s", "m^3/s"), BaseUnit("CubicMeterPerSecond"), LongName("cubic meter per second")]
            [UnitCategory(UnitCategory.Flow), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            CubicMeterPerSecond,

            [Symbol("m³/h", "m^3/h"), BaseUnit("CubicMeterPerSecond"), LongName("cubic meter per hour")]
            [UnitCategory(UnitCategory.Flow), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d / 3600d)]
            CubicMeterPerHour,
            #endregion

            #region Energy
            [Symbol("J", "Nm", "kg·m²·s¯²", "kg·m^2·s^-2", "Nm"), BaseUnit("Joule"), LongName("joule")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1)]
            Joule,

            [Symbol("mJ"), BaseUnit("Joule"), LongName("millijoule")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e-3)]
            MilliJoule,

            [Symbol("kJ"), BaseUnit("Joule"), LongName("kilojoule")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            KiloJoule,

            [Symbol("MJ"), BaseUnit("Joule"), LongName("megajoule")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e6)]
            MegaJoule,

            [Symbol("GJ"), BaseUnit("Joule"), LongName("gigajoule")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e9)]
            GigaJoule,

            [Symbol("kWh"), BaseUnit("Joule"), LongName("kilowatt hour")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d / 3.6e6)]
            KiloWattHour,

            [Symbol("eV"), BaseUnit("Joule"), LongName("electron volt")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1.602176565e-19)]
            Electronvolt,

            [Symbol("meV"), BaseUnit("Joule"), LongName("millielectron volt") ]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1.602176565e-22)]
            MilliElectronvolt,

            [Symbol("keV"), BaseUnit("Joule"), LongName("kiloelectron volt") ]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1.602176565e-16)]
            KiloElectronvolt,

            [Symbol("MeV"), BaseUnit("Joule"), LongName("megaelectron volt") ]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1.602176565e-13)]
            MegaElectronvolt,

            [Symbol("kpm"), BaseUnit("Joule"), LongName("kilopond meter")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 0.102d)]
            Kilopondmeter,

            [Symbol("erg", "cm²·g·s¯²", "cm^2·g·s^-2"), BaseUnit("Joule"), LongName("erg")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 1e7)]
            Erg,

            //pre-SI metric energy
            [Symbol("cal"), BaseUnit("Joule"), LongName("calorie")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 0.239005736d)]
            Calorie,

            [Symbol("mcal"), BaseUnit("Joule"), LongName("millicalorie")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 0.239005736e-3)]
            MilliCalorie,

            [Symbol("kcal"), BaseUnit("Joule"), LongName("kilocalorie") ]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 0.239005736e-3)]
            KiloCalorie,

            [Symbol("Mcal"), BaseUnit("Joule"), LongName("megacalorie")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.Historic)]
            [Conversion(0d, 0.239005736e-6)]
            MegaCalorie,

            //imperial or United States customary energy
            [Symbol("BTU"), BaseUnit("Joule"), LongName("british thermal unit")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.Imperial)]
            [Conversion(0d, 1055.05585262)]
            BritishThermalUnit,

            [Symbol("ftlb"), BaseUnit("Joule"), LongName("foot pound")]
            [UnitCategory(UnitCategory.Energy), UnitSystem(UnitSystem.Imperial)]
            [Conversion(0d, 1.3558179483314004)]
            FootPound,
            #endregion

            #region Power
            [Symbol("W", "J/s", "VA", "m²·kg·s¯³", "m^2·kg·s^-3"), BaseUnit("Watt"), LongName("watt")]
            [UnitCategory(UnitCategory.Power), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Watt,

            [Symbol("mW"), BaseUnit("Watt"), LongName("milliwatt")]
            [UnitCategory(UnitCategory.Power), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e-3)]
            MilliWatt,

            [Symbol("kW"), BaseUnit("Watt"), LongName("kilowatt")]
            [UnitCategory(UnitCategory.Power), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            KiloWatt,

            [Symbol("MW"), BaseUnit("Watt"), LongName("megawatt")]
            [UnitCategory(UnitCategory.Power), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e6)]
            MegaWatt,
            #endregion

            #region ElectricCharge
            [Symbol("C", "As"), BaseUnit("Coulomb"), LongName("coulomb") ]
            [UnitCategory(UnitCategory.ElectricCharge), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Coulomb,

            [Symbol("Fr", "(g·cm³)exp0.5/s"), BaseUnit("Coulomb"), LongName("Franklin") ]
            [UnitCategory(UnitCategory.ElectricCharge), UnitSystem(UnitSystem.CGS_Coherent)]
            [Conversion(0d, 2997924580d)]
            Franklin,
            #endregion

            #region  Capacitance
            [Symbol("F", "C/V", "A·s/V", "m¯²·kg¯¹·s^4·A²"), BaseUnit("Farad"), LongName("farad") ]
            [UnitCategory(UnitCategory.Capacitance), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Farad,

            [Symbol("mF"), BaseUnit("Farad"), LongName("millifarad")]
            [UnitCategory(UnitCategory.Capacitance), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            MilliFarad,

            [Symbol("µF"), BaseUnit("Farad"), LongName("microfarad")]
            [UnitCategory(UnitCategory.Capacitance), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e6)]
            MicroFarad,

            [Symbol("nF"), BaseUnit("Farad"), LongName("nanofarad")]
            [UnitCategory(UnitCategory.Capacitance), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e9)]
            NanoFarad,

            [Symbol("pF"), BaseUnit("Farad"), LongName("picofarad")]
            [UnitCategory(UnitCategory.Capacitance), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e12)]
            PicoFarad,
            #endregion

            #region Resistivity
            [Symbol("Ohm", "Ω", "V/A", "m²·kg·s¯³·A¯²"), BaseUnit("Ohm"), LongName("ohm")]
            [UnitCategory(UnitCategory.Resistivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Ohm,

            [Symbol("mOhm", "mΩ"), BaseUnit("Ohm"), LongName("milliohm")]
            [UnitCategory(UnitCategory.Resistivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e-3)]
            MilliOhm,

            [Symbol("kOhm", "kΩ"), BaseUnit("Ohm"), LongName("kiloohm")]
            [UnitCategory(UnitCategory.Resistivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            KiloOhm,

            [Symbol("MOhm", "MΩ"), BaseUnit("Ohm"), LongName("megaohm")]
            [UnitCategory(UnitCategory.Resistivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e6)]
            MegaOhm,
            #endregion

            #region MagneticFlux
            [Symbol("Wb", "V·s", "T·m²", "J/A", "m²·kg·s¯²·A¯¹"), BaseUnit("Weber"), LongName("weber")]
            [UnitCategory(UnitCategory.MagneticFlux), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Weber,

            [Symbol("µWb"), BaseUnit("Weber"), LongName("microweber")]
            [UnitCategory(UnitCategory.MagneticFlux), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e-6)]
            MicroWeber,

            [Symbol("mWb"), BaseUnit("Weber"), LongName("milliweber")]
            [UnitCategory(UnitCategory.MagneticFlux), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e-3)]
            MilliWeber,

            [Symbol("kWb"), BaseUnit("Weber"), LongName("kiloweber")]
            [UnitCategory(UnitCategory.MagneticFlux), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            KiloWeber,

            [Symbol("MWb"), BaseUnit("Weber"), LongName("mgaweber")]
            [UnitCategory(UnitCategory.MagneticFlux), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e6)]
            MegaWeber,

            [Symbol("Mx", "maxwell", "gauss·mc²"), BaseUnit("Weber"), LongName("maxwell")]
            [UnitCategory(UnitCategory.MagneticFlux), UnitSystem(UnitSystem.CGS)]
            [Conversion(0d, 1e8)]
            Maxwell,
            #endregion 

            #region  MagneticFluxDensity
            [Symbol("T", "Wb/m2", "V·s/m²", "N/(A·m)", "J/(A·m²)","kg/(C·s)", "N·s/(C·m)", "kg·s¯²·A¯¹"), BaseUnit("Tesla"), LongName("tesla")]
            [UnitCategory(UnitCategory.MagneticFluxDensity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Tesla,

            [Symbol("mT"), BaseUnit("Tesla"), LongName("millitesla")]
            [UnitCategory(UnitCategory.MagneticFluxDensity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            MilliTesla,

            [Symbol("µT"), BaseUnit("Tesla"), LongName("microtesla")]
            [UnitCategory(UnitCategory.MagneticFluxDensity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e6)]
            MircoTesla,

            [Symbol("nT"), BaseUnit("Tesla"), LongName("nanotesla")]
            [UnitCategory(UnitCategory.MagneticFluxDensity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e9)]
            NanoTesla,

            [Symbol("gauss", "G", "Gs"), BaseUnit("Tesla"), LongName("gauss")]
            [UnitCategory(UnitCategory.MagneticFluxDensity), UnitSystem(UnitSystem.CGS)]
            [Conversion(0d, 1e4)]
            Gauss,

            [Symbol("gamma", "γ"), BaseUnit("Tesla"), LongName("gamma")]
            [UnitCategory(UnitCategory.MagneticFluxDensity), UnitSystem(UnitSystem.CGS)]
            [Conversion(0d, 1e9)]
            Gamma,
            #endregion

            #region Inductivity
            [Symbol("H", "Wb/A" ,"m²·kg·s¯²·A¯²"), BaseUnit("Henry"), LongName("henry") ]
            [UnitCategory(UnitCategory.Inductivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Henry,

            [Symbol("µH"), BaseUnit("Henry"), LongName("microhenry")]
            [UnitCategory(UnitCategory.Inductivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e6)]
            MicroHenry,

            [Symbol("mH"), BaseUnit("Henry"), LongName("millihenry")]
            [UnitCategory(UnitCategory.Inductivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e3)]
            MillHenry,

            [Symbol("kH"), BaseUnit("Henry"), LongName("kilohenry")]
            [UnitCategory(UnitCategory.Inductivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e-3)]
            KiloHenry,

            [Symbol("MH"), BaseUnit("Henry"), LongName("Megahenry")]
            [UnitCategory(UnitCategory.Inductivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1e-6)]
            MegaHenry,
            #endregion

            #region Time
            [Symbol("s"), BaseUnit("Second"), LongName("second")]
            [UnitCategory(UnitCategory.Time), UnitSystem(UnitSystem.SI)]
            [Conversion(0d, 1d)]
            Second,

            [Symbol("ms"), BaseUnit("Second"), LongName("millisecond")]
            [UnitCategory(UnitCategory.Time), UnitSystem(UnitSystem.SI)]
            [Conversion(0d, 1e3)]
            MilliSecond,

            [Symbol("µs"), BaseUnit("Second"), LongName("microsecond")]
            [UnitCategory(UnitCategory.Time), UnitSystem(UnitSystem.SI)]
            [Conversion(0d, 1e6)]
            MicroSecond,

            [Symbol("ns"), BaseUnit("Second"), LongName("nanosecond")]
            [UnitCategory(UnitCategory.Time), UnitSystem(UnitSystem.SI)]
            [Conversion(0d, 1e9)]
            NanoSecond,

            [Symbol("ps"), BaseUnit("Second"), LongName("picosecond")]
            [UnitCategory(UnitCategory.Time), UnitSystem(UnitSystem.SI)]
            [Conversion(0d, 1e12)]
            PicoSecond,

            [Symbol("min"), BaseUnit("Second"), LongName("minute")]
            [UnitCategory(UnitCategory.Time), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1d / 60d)]
            Minute,

            [Symbol("h"), BaseUnit("Second"), LongName("hour")]
            [UnitCategory(UnitCategory.Time), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1d / 3600d)]
            Hour,

            [Symbol("d"), BaseUnit("Second"), LongName("day")]
            [UnitCategory(UnitCategory.Time), UnitSystem(UnitSystem.SI_NotCoherent)]
            [Conversion(0d, 1d / 86400d)]
            Day,
            #endregion

            #region Drift Rate 
            [Symbol("s/d"), BaseUnit("SecondPerDay"), LongName("seconds per day")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d)]
            SecondPerDay,

            [Symbol("ms/d"), BaseUnit("SecondPerDay"), LongName("milliseconds per day")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e3)]
            MilliSecondPerDay,

            [Symbol("µs/d"), BaseUnit("SecondPerDay"), LongName("microseconds per day")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e6)]
            MicroSecondPerDay,

            [Symbol("ns/d"), BaseUnit("SecondPerDay"), LongName("nanoseconds per day")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e9)]
            NanoSecondPerDay,

            [Symbol("ps/d"), BaseUnit("SecondPerDay"), LongName("picoseconds per day")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e12)]
            PicoSecondPerDay,

            [Symbol("s/a"), BaseUnit("SecondPerDay"), LongName("seconds per year")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d / 365.25)]
            SecondPerYear,

            [Symbol("ms/a"), BaseUnit("SecondPerDay"), LongName("milliseconds per year")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e3 / 365.25)]
            MilliSecondPerYear,

            [Symbol("µs/a"), BaseUnit("SecondPerDay"), LongName("microseconds per year")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e6 / 365.25)]
            MicroSecondPerYear,

            [Symbol("ns/a"), BaseUnit("SecondPerDay"), LongName("nanoseconds per year")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e9 / 365.25)]
            NanoSecondPerYear,

            [Symbol("ps/d"), BaseUnit("SecondPerDay"), LongName("picoseconds per year")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1e12 / 365.25)]
            PicoSecondPerYear,

            [Symbol("min/d"), BaseUnit("SecondPerDay"), LongName("minutes per day")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d / 60d)]
            MinutesPerDay,

            [Symbol("min/a"), BaseUnit("SecondPerDay"), LongName("minutes per year")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d / 60d / 365.25)]
            MinutesPerYear,

            [Symbol("h/d"), BaseUnit("SecondPerDay"), LongName("hours per day")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d / 3600d)]
            HoursPerDay,

            [Symbol("h/a"), BaseUnit("SecondPerDay"), LongName("hours per year")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d / 3600d / 365.25)]
            HoursPerYear,

            [Symbol("d/a"), BaseUnit("SecondPerDay"), LongName("days per year")]
            [UnitCategory(UnitCategory.DriftRate), UnitSystem(UnitSystem.SI_Coherent)]
            [Conversion(0d, 1d / 86400d / 365.25)]
            DaysPerYear,
            #endregion

            #region LuminousFlux
            [Symbol("lm", "cd·sr", "cd"), BaseUnit("Lumen"), LongName("lumen")]
            [UnitCategory(UnitCategory.LuminousFlux), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Lumen,
            #endregion

            #region Illuminance
            [Symbol("lx", "lm/m²" ,"m¯²·cd"), BaseUnit("Lux"), LongName("lux")]
            [UnitCategory(UnitCategory.Illuminance), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Lux,
            #endregion

            #region Radioactivity
            [Symbol("Bq", "s¯¹"), BaseUnit("Becquerel"), LongName("becquerel")]
            [UnitCategory(UnitCategory.Radioactivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Becquerel,

            [Symbol("Ci"), BaseUnit("Becquerel"), LongName("curie")]
            [UnitCategory(UnitCategory.Radioactivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 2.7e-11)]
            Curie,

            [Symbol("µCi"), BaseUnit("Becquerel"), LongName("microcurie")]
            [UnitCategory(UnitCategory.Radioactivity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 2.7e-5)]
            MicroCurie,
            #endregion

            #region IonizingRadiation
            [Symbol("Sv", "J/kg" ,"m²·s¯²"), BaseUnit("Sievert"), LongName("sievert")]
            [UnitCategory(UnitCategory.IonizingRadiation), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            Sievert,
            #endregion 
            
            #region SignalToNoiseRatio
            [Symbol("dB"), BaseUnit("dB"), LongName("decibel")]
            [UnitCategory(UnitCategory.SignalToNoiseRatio), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            dB,

            [Symbol("dBm" ), BaseUnit("dBm"), LongName("decibel milliwats")]
            [UnitCategory(UnitCategory.SignalToNoiseRatio), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            dBm,
            #endregion

            #region Humidity
            [Symbol("%rH"), BaseUnit("RelativeHumidity"), LongName("relative humidity")]
            [UnitCategory(UnitCategory.Humidity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            RelativeHumidity, // hier gibts noch mehr, aber nicht so einfach umzurechnen 

            [Symbol("%H"), BaseUnit("PercentHumidity"), LongName("percent humidity")]
            [UnitCategory(UnitCategory.Humidity), UnitSystem(UnitSystem.SI_Derived)]
            [Conversion(0d, 1d)]
            PercentHumidity,
            #endregion

            #region TidalPotential
            [Symbol("(m/s)²"), BaseUnit("MeterSquaredPerSecondSquared"), LongName("metersquared per secondsquared")]
            [UnitCategory(UnitCategory.TidalPoteltial), UnitSystem(UnitSystem.All)]
            [Conversion(0d, 1d)]
            MeterSquaredPerSecondSquared, 
            #endregion

            #region Custom
            [Symbol("count"), BaseUnit("Count"), LongName("count")]
            [UnitCategory(UnitCategory.Custom), UnitSystem(UnitSystem.All)]
            [Conversion(0d, 1d)]
            Count,
            #endregion
        }

        #region Category
        /// <summary>
        /// Category of a unit (attribute of 'UnitNamesEnum').
        /// </summary>
        public enum UnitCategory
        {
            None,
            [Category("Unknown")]
            Unknown,
            [Category("Unity")]
            Unity,
            [Category("Length")]
            Length,
            [Category("Areal")]
            Areal,
            [Category("Volume")]
            Volume,
            [Category("Mass")]
            Mass,
            [Category("Time")]
            Time,
            [Category("Drift Rate")]
            DriftRate,
            [Category("Angle")]
            Angle,
            [Category("Angular Acceleration")]
            AngularAcceleration,
            [Category("Velocity")]
            Velocity,
            [Category("Pressure")]
            Pressure,
            [Category("Frequency / Rotational speed")]
            Frequency,
            [Category("Acceleration / Gravity")]
            Gravity,
            [Category("Gravity Gradient")]
            GravityGradient,
            [Category("Acceleration / Gravity change")]
            GravityChange,
            [Category("Temperature")]
            Temperature,
            [Category("Relative length change")]
            Strain,
            [Category("Humidity")]
            Humidity,
            [Category("Tidal Poteltial")]
            TidalPoteltial,
            [Category("Force")]
            Force,
            [Category("Energy")]
            Energy,
            [Category("Power")]
            Power,
            [Category("Electric potential")]
            ElectricPotential,
            [Category("Electric resistivity")]
            Resistivity,
            [Category("Electric capacitance")]
            Capacitance,
            [Category("Electric inductivity")]
            Inductivity,
            [Category("Electric charge")]
            ElectricCharge,
            [Category("Magnetic flux")]
            MagneticFlux,
            [Category("Magnetic flux density")]
            MagneticFluxDensity,
            [Category("Luminous flux")]
            LuminousFlux,
            [Category("Illuminance")]
            Illuminance,
            [Category("Radioactivity")]
            Radioactivity,
            [Category("Ionizing radiation")]
            IonizingRadiation,
            [Category("Signal to noise ratio")]
            SignalToNoiseRatio,
            [Category("Flow")]
            Flow,

            [Category("Custom")]
            Custom,

            All,
        }
        #endregion

        #region System
        /// <summary>
        /// System of a unit  (attribute of 'UnitNamesEnum').
        /// </summary>
        [Flags]
        public enum UnitSystem
        {
            None = 1<< 0,
            Unity = 1 << 1,
            SI = 1 << 2,
            CGS = 1 << 3,
            US = 1 << 4,
            Imperial = 1 << 5,
            Coherent = 1 << 6,
            NotCoherent = 1 << 7,
            Derived = 1 << 8,
            Historic = 1 << 9,

            SI_Coherent = SI | Coherent,
            SI_NotCoherent = SI | NotCoherent,
            SI_Derived = SI | Derived,
            CGS_Coherent = CGS | Coherent,
            CGS_NotCoherent = CGS | NotCoherent,
            US_Imperial = US | Imperial,

            All = Unity | SI | CGS | US | Imperial | Coherent | NotCoherent | Derived | Historic | SI_Coherent | SI_NotCoherent | SI_Derived |
                  CGS_Coherent | CGS_NotCoherent | US_Imperial,
        }
        #endregion

        #region Attributes
        /// <summary>
        /// Attribute of 'UnitNamesEnum' delivers the symbol.
        /// </summary>
        internal class SymbolAttribute : Attribute
        {
            private readonly string[] _symbol = null;

            public SymbolAttribute(params string[] symbol)
            {
                _symbol = symbol;
            }

            /// <summary>
            /// Returns the standard symbol of a 'UnitNamesEnum' (a unit).
            /// </summary>
            public string Symbol 
            {
                get { return _symbol[0]; }
            }

            /// <summary>
            /// Returns the alternative symbols of a 'UnitNamesEnum' (a unit).
            /// </summary>
            public string[] AlternativeSymbol
            {
                get { return _symbol; }
            }
        }

        /// <summary>
        /// Attribute of 'UnitNamesEnum' delivers the category.
        /// </summary>
        internal class UnitCategoryAttribute : Attribute
        {
            public UnitCategoryAttribute(UnitCategory unitCategory)
            {
                UnitCategory = unitCategory;
            }

            /// <summary>
            /// Returns the category of a 'UnitNamesEnum' (a unit).
            /// </summary>
            public UnitCategory UnitCategory { get; private set; }
        }

        /// <summary>
        /// Attribute of 'UnitNamesEnum' delivers the system.
        /// </summary>
        internal class UnitSystemAttribute : Attribute
        {
            public UnitSystemAttribute(UnitSystem unitSystem)
            {
                UnitSystem = unitSystem;
            }

            /// <summary>
            /// Returns the system of a 'UnitNamesEnum' (a unit).
            /// </summary>
            public UnitSystem UnitSystem { get; private set; }
        }

        /// <summary>
        /// Attribute of 'UnitNamesEnum' delivers the base unit.
        /// </summary>
        internal class BaseUnitAttribute : Attribute
        {
            public BaseUnitAttribute(string baseUnit)
            {
                BaseUnit = baseUnit;
            }

            /// <summary>
            /// Returns the base unit (as 'UnitNamesEnum') of a 'UnitNamesEnum' (a unit).
            /// </summary>
            public string BaseUnit { get; private set; }
        }

        /// <summary>
        /// Attribute of 'UnitNamesEnum' delivers the long name.
        /// </summary>
        internal class LongNameAttribute : Attribute
        {
            public LongNameAttribute(string longName)
            {
                LongName = longName;
            }
            /// <summary>
            /// Returns the long name of a 'UnitNamesEnum' (a unit).
            /// </summary>
            public string LongName{ get; private set; }
        }

        /// <summary>
        /// Attribute of 'UnitNamesEnum' delivers the conversion to other units of the same category.
        /// </summary>
        internal class ConversionAttribute : Attribute
        {
            public ConversionAttribute(params double[] x)
            {
                Conversion = x;
            }

            /// <summary>
            /// Returns the offset and linear dependence of a unit releted to the base unit.
            /// </summary>
            public double[] Conversion { get; private set; }
        }
       
        /// <summary>
        /// Attribute of 'Category' delivers the conversion to other units of the same category.
        /// </summary>
        internal class CategoryAttribute : Attribute
        {
            public CategoryAttribute(string categoryDescription)
            {
                CategoryDescription  = categoryDescription;
            }
            /// <summary>
            /// Returns the category description of a 'Category'.
            /// </summary>
            public string CategoryDescription { get; private set; }
        }
        
        #endregion

        /// <summary>
        /// Class for calculations with units. Not Finished!!!!
        /// </summary>
        public class ValueWithUnit
        {
            public double Value = double.NaN;

            // properties
            public readonly UnitNamesEnum Unit = UnitNamesEnum.Unknown;
            public readonly string Symbol = null;
            public readonly UnitNamesEnum BaseUnit = UnitNamesEnum.Unknown;
            public readonly string BaseUnitSymbol = null;
            public readonly UnitNamesEnum[] GroupMemberMetricUnits = null;
            public readonly string[] GroupMemberMetricSymbols = null;
            public readonly UnitNamesEnum[] GroupMemberAllUnits = null;
            public readonly string[] GroupMemberAllSymbols = null;
            public readonly UnitSystem UnitSystem = UnitSystem.None;
            
            // constructors
            public ValueWithUnit(double value, UnitNamesEnum unit)
            {
                this.Value = value;
                this.Unit = unit;
                this.Symbol = GetUnitSymbol(Unit);
                this.BaseUnit = GetBaseUnit(Unit);
                this.BaseUnitSymbol = GetUnitSymbol(BaseUnit);
                this.UnitSystem = GetUnitSystem(Unit);
                this.GroupMemberMetricUnits = GetUnitMembersOfGroup(Unit, UnitSystem.SI);
                this.GroupMemberMetricSymbols = GetUnitSymbolsOfGroup(Unit, UnitSystem.SI);
                this.GroupMemberAllUnits =      GetUnitMembersOfGroup(Unit, UnitSystem.All);
                this.GroupMemberAllSymbols = GetUnitSymbolsOfGroup(Unit, UnitSystem.All);
            }

            public ValueWithUnit(double value, string symbol)
            {
                this.Value = value;
                this.Unit = GetUnitNameEnumerator(symbol);
                this.Symbol = symbol;
                this.BaseUnit = GetBaseUnit(Unit);
                this.BaseUnitSymbol = GetUnitSymbol(BaseUnit);
                this.GroupMemberMetricUnits = GetUnitMembersOfGroup(Unit, UnitSystem.SI);
                this.GroupMemberMetricSymbols = GetUnitSymbolsOfGroup(Unit, UnitSystem.SI);
                this.GroupMemberAllUnits = GetUnitMembersOfGroup(Unit, UnitSystem.All);
                this.GroupMemberAllSymbols = GetUnitSymbolsOfGroup(Unit, UnitSystem.All);
                this.UnitSystem = GetUnitSystem(Unit);
            }

            public ValueWithUnit(UnitNamesEnum unit)
            {
                this.Value = 1d;
                this.Unit = unit;
                this.Symbol = GetUnitSymbol(Unit);
                this.BaseUnit = GetBaseUnit(Unit);
                this.BaseUnitSymbol = GetUnitSymbol(BaseUnit);
                this.GroupMemberMetricUnits = GetUnitMembersOfGroup(Unit, UnitSystem.SI);
                this.GroupMemberMetricSymbols = GetUnitSymbolsOfGroup(Unit, UnitSystem.SI);
                this.GroupMemberAllUnits = GetUnitMembersOfGroup(Unit, UnitSystem.All);
                this.GroupMemberAllSymbols = GetUnitSymbolsOfGroup(Unit, UnitSystem.All);
                this.UnitSystem = GetUnitSystem(Unit);
            }

            public ValueWithUnit(string symbol)
            {
                this.Value = 1d;
                this.Unit = GetUnitNameEnumerator(symbol);
                this.Symbol = symbol;
                this.BaseUnit = GetBaseUnit(Unit);
                this.BaseUnitSymbol = GetUnitSymbol(BaseUnit);
                this.GroupMemberMetricUnits = GetUnitMembersOfGroup(Unit, UnitSystem.SI);
                this.GroupMemberMetricSymbols = GetUnitSymbolsOfGroup(Unit, UnitSystem.SI);
                this.GroupMemberAllUnits = GetUnitMembersOfGroup(Unit, UnitSystem.All);
                this.GroupMemberAllSymbols = GetUnitSymbolsOfGroup(Unit, UnitSystem.All);
                this.UnitSystem = GetUnitSystem(Unit);
            }

            // Methods
            public double ConvertToValue(UnitNamesEnum unit)
            {
                return ConvertByUnits(this.Value, this.Unit, unit);
            }

            public ValueWithUnit ConvertToValueWithUnit(UnitNamesEnum unit)
            {
                return new ValueWithUnit(ConvertByUnits(this.Value, this.Unit, unit), unit);
            }
        }

        // Method: Symbols
        /// <summary>
        /// Delivers the unit symbol of a unit (enum).
        /// </summary>
        /// <param name="unit">Unit enumerator.</param>
        /// <returns>Symbol of the unit.</returns>
        public static string GetUnitSymbol(this UnitNamesEnum unit)
        {
            FieldInfo fi = unit.GetType().GetField(unit.ToString());

            SymbolAttribute[] attributes = (SymbolAttribute[])fi.GetCustomAttributes(typeof(SymbolAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Symbol;
            else
                return unit.ToString();
        }
        
        /// <summary>
        /// Delivers the all alternative unit symbols of a unit (enum).
        /// </summary>
        /// <param name="unit">Unit enumerator.</param>
        /// <returns>Alternative symbols of the unit.</returns>
        public static string[] GetAlternativeUnitSymbol(this UnitNamesEnum unit)
        {
            FieldInfo fi = unit.GetType().GetField(unit.ToString());
            SymbolAttribute[] attributes = (SymbolAttribute[])fi.GetCustomAttributes(typeof(SymbolAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                string[] tmp = null;
                if (attributes[0].AlternativeSymbol.Length > 1)
                {
                    tmp = new string[attributes[0].AlternativeSymbol.Length-1];
                    Array.Copy(attributes[0].AlternativeSymbol, 1, tmp, 0, tmp.Length);
                }
                return tmp;
            }
            else
                return null;
        }
        
        /// <summary>
        /// Delivers all symbols of a unit according to its group and given unit system.
        /// </summary>
        /// <param name="unit">Unit enumerator. </param>
        /// <param name="unitSystem">System of the units to be delivered.</param>
        /// <returns>All symbols of a unit accordint to its group and given unit system.</returns>
        public static string[] GetUnitSymbolsOfGroup(this UnitNamesEnum unit, UnitSystem unitSystem)
        {
            UnitCategory uk = GetUnitCategory(unit);
            Array array = System.Enum.GetValues(typeof(UnitNamesEnum));
            System.Collections.ArrayList list = new System.Collections.ArrayList();

            foreach (UnitNamesEnum a in array)
            {
                UnitSystem s = GetUnitSystem(a);
                if ((uk == GetUnitCategory(a)) && (unitSystem & s) == s)
                    list.Add(GetUnitSymbol(a));
            }

            string[] names = list.ToArray(typeof(string)) as string[];
            return names;
        }

        /// <summary>
        /// Delivers all symbols of a given category and unit system.
        /// </summary>
        /// <param name="category">Category of units to be delivered.</param>
        /// <param name="unitSystem">System of units to be delivered.</param>
        /// <returns></returns>
        public static string[] GetUnitSymbolByCatogry(string category, UnitSystem unitSystem)
        {
            UnitCategory uk = GetUnitCategoryByDescription(category);
            Array array = System.Enum.GetValues(typeof(UnitNamesEnum));
            System.Collections.ArrayList list = new System.Collections.ArrayList();

            foreach (UnitNamesEnum a in array)
            {
                UnitSystem s = GetUnitSystem(a);
                if ((uk == GetUnitCategory(a)) && (unitSystem & s) == s)
                    list.Add(GetUnitSymbol(a));
            }
            string[] names = list.ToArray(typeof(string)) as string[];
            return names;
        }

        /// <summary>
        /// Delivers all known unit symbols.
        /// </summary>
        /// <returns>All known symbol of units (enum).</returns>
        public static string[] getAllUnitSymbols()
        {
            UnitNamesEnum[] allNames = GetAllUnitNameEnumerator();
            string[] symbols = new string[allNames.Length];

            for (int i = 0; i < allNames.Length; i++)
                symbols[i] = GetUnitSymbol(allNames[i]);

            return symbols;
        }
        
        // Method: Unit
        /// <summary>
        /// Delivers the unit (enum) for a given symbol.
        /// </summary>
        /// <param name="symbol">Symbol of unit.</param>
        /// <returns>Unit enumerator.</returns>
        public static UnitNamesEnum GetUnitNameEnumerator(this string symbol)
        {
            UnitNamesEnum result = UnitNamesEnum.Unknown;
            foreach (UnitNamesEnum id in Enum.GetValues(typeof(UnitNamesEnum)))
            {
                SymbolAttribute[] attribute = (SymbolAttribute[])Attribute.GetCustomAttributes(id.GetType().GetField(id.ToString()), typeof(SymbolAttribute));

                if (attribute != null && Array.IndexOf(attribute[0].AlternativeSymbol, symbol) >= 0)
                {
                    result = id;
                    break;
                }
            }
            return result;
        }
        
        /// <summary>
        /// Delivers all known units (enum).
        /// </summary>
        /// <returns>All knwon units.</returns>
        public static UnitNamesEnum[] GetAllUnitNameEnumerator()
        {
            return Enum.GetValues(typeof(UnitNamesEnum)) as UnitNamesEnum[];
        }
        
        /// <summary>
        /// Delivers all unit (enum) members of a given unit and its category and sytem.
        /// </summary>
        /// <param name="value">Unit enumerator.</param>
        /// <param name="unitSystem">System of the units to be delivered.</param>
        /// <returns>All members units (enum) of a given unit and sytem according to its own category.</returns>
        public static UnitNamesEnum[] GetUnitMembersOfGroup(this UnitNamesEnum value, UnitSystem unitSystem)
        {
            UnitCategory uk = GetUnitCategory(value);

            Array array = System.Enum.GetValues(typeof(UnitNamesEnum));
            System.Collections.ArrayList list = new System.Collections.ArrayList();

            foreach (UnitNamesEnum a in array)
            {
                UnitSystem s = GetUnitSystem(a);
                if ((GetUnitCategory(a) == uk) && (unitSystem & s) == s)
                    list.Add(a);
            }

            UnitNamesEnum[] names = null;
            if (list.Count > 0)
                names = list.ToArray(typeof(UnitNamesEnum)) as UnitNamesEnum[];
            return names;
        }
        
        /// <summary>
        /// Delivers all units (enum) of a given category and sytem.
        /// </summary>
        /// <param name="category">Category of the units to be delivered.</param>
        /// <param name="unitSystem">System of the units to be delivered.</param>
        /// <returns>All units (enum) of a given category and sytem.</returns>
        public static UnitNamesEnum[] GetUnitMembersOfGroup(this UnitCategory category, UnitSystem unitSystem)
        {
            Array array = System.Enum.GetValues(typeof(UnitNamesEnum));
            System.Collections.ArrayList list = new System.Collections.ArrayList();

            foreach (UnitNamesEnum a in array)
            {
                UnitCategory c = GetUnitCategory(a);
                UnitSystem s = GetUnitSystem(a);
                if (((category & c) == c) && (unitSystem & s) == s)
                    list.Add(a);
            }

            UnitNamesEnum[] names = null;
            if (list.Count > 0)
                names = list.ToArray(typeof(UnitNamesEnum)) as UnitNamesEnum[];
            return names;
        }

        // Method: Category
        /// <summary>
        /// Delivers the category (enum) from a unit (enum).
        /// </summary>
        /// <param name="unit">Unit enumerator.</param>
        /// <returns>The unit category (enum).</returns>
        public static UnitCategory GetUnitCategory(this UnitNamesEnum unit)
        {
            var unitKindAttr = (UnitCategoryAttribute)typeof(UnitNamesEnum).GetField(Enum.GetName(typeof(UnitNamesEnum), unit))
                .GetCustomAttributes(typeof(UnitCategoryAttribute), false)[0];
            return unitKindAttr.UnitCategory;
        }
        
        /// <summary>
        ///  Delivers the category description from a unit (enum).
        /// </summary>
        /// <param name="unit">Unit enumerator.</param>
        /// <returns>The category description.</returns>
        public static string GetUnitCategoryDescriprion(this UnitNamesEnum unit)
        {
            UnitCategory uc = GetUnitCategory(unit);

            var unitKindAttr = (CategoryAttribute)typeof(UnitCategory).GetField(Enum.GetName(typeof(UnitCategory), uc))
                .GetCustomAttributes(typeof(CategoryAttribute), false)[0];

            return unitKindAttr.CategoryDescription;
        }
        
        /// <summary>
        /// Delivers the category (enum) from a category description.
        /// </summary>
        /// <param name="category">Cetegory description.</param>
        /// <returns>The unit category (enum).</returns>
        public static UnitCategory GetUnitCategoryByDescription(this string category)
        {
            var type = typeof(UnitCategory);
            if (!type.IsEnum)
                throw new ArgumentException();
            FieldInfo[] fields = type.GetFields();
            var field = fields.SelectMany(f => f.GetCustomAttributes(
                      typeof(CategoryAttribute), false), (f, a) => new { Field = f, Att = a })
                            .Where(a => ((CategoryAttribute)a.Att).CategoryDescription == category).SingleOrDefault();
            return field == null ? default(UnitCategory) : (UnitCategory)field.Field.GetRawConstantValue();
        }
        
        /// <summary>
        /// Delivers all existing categories descriptions.
        /// </summary>
        /// <returns>Array of all existing categories descriptions.</returns>
        public static string[] GetAllCategoriesDescription()
        {
            UnitCategory[] category = Enum.GetValues(typeof(UnitCategory)) as UnitCategory[];
            System.Collections.ArrayList list = new System.Collections.ArrayList();

            for(int i = 0;i < category.Length; i++)
            {
                FieldInfo fi = category[i].GetType().GetField(category[i].ToString());
                CategoryAttribute[] attributes = (CategoryAttribute[])fi.GetCustomAttributes(typeof(CategoryAttribute), false);
                if (attributes != null && attributes.Length > 0)
                list.Add(attributes[0].CategoryDescription);
            }
            string[] tmp = (string[])list.ToArray(typeof(string));
            return tmp;
        }

        // Method: System
        /// <summary>
        /// Delivers the system of the unit.
        /// </summary>
        /// <param name="unit">Unit enumerator.</param>
        /// <returns>The system of the unit.</returns>
        public static UnitSystem GetUnitSystem(this UnitNamesEnum unit)
        {
            var unitKindAttr = (UnitSystemAttribute)typeof(UnitNamesEnum).GetField(Enum.GetName(typeof(UnitNamesEnum), unit))
                    .GetCustomAttributes(typeof(UnitSystemAttribute), false)[0];
            return unitKindAttr.UnitSystem;
        }

        // Method: determine BaseUnit from given unit
        /// <summary>
        /// Delivers the base unit of the unit, according to its group.
        /// </summary>
        /// <param name="unit">Unit enumerator.</param>
        /// <returns>The base unit of the unit, according to its group.</returns>
        public static UnitNamesEnum GetBaseUnit(this UnitNamesEnum unit)
        {
            var unitKindAttr = (BaseUnitAttribute)typeof(UnitNamesEnum).GetField(Enum.GetName(typeof(UnitNamesEnum), unit))
                           .GetCustomAttributes(typeof(BaseUnitAttribute), false)[0];
            return (UnitNamesEnum)Enum.Parse(typeof(UnitNamesEnum), unitKindAttr.BaseUnit);
        }

        // Method: Long name
        /// <summary>
        /// Delivers the long name of a unit (enum).
        /// </summary>
        /// <param name="unit">Unit enumerator.</param>
        /// <returns>The long name of the unit.</returns>
        public static string GetUnitLongName(this UnitNamesEnum unit)
        {
            var unitKindAttr = (LongNameAttribute)typeof(UnitNamesEnum).GetField(Enum.GetName(typeof(UnitNamesEnum), unit))
                .GetCustomAttributes(typeof(LongNameAttribute), false)[0];
            return unitKindAttr.LongName;
        }

        // Method: check for unit known
        /// <summary>
        /// Verifies if a unit symbol exists.
        /// </summary>
        /// <param name="symbol">Symbol to be verified.</param>
        /// <returns>Known symbol (true), unknown (false).</returns>
        public static bool isKnownUnit(string symbol)
        {
            return GetUnitNameEnumerator(symbol) == UnitNamesEnum.Unknown ? false : true;
        }

        // Methods: Convserion
        /// <summary>
        /// Struct keeping the convserion values between units.
        /// </summary>
        public struct Conversion
        {
            /// <summary>
            /// Factor for conversion between units.
            /// </summary>
            public double Factor;

            /// <summary>
            /// Offset for conversion between units.
            /// </summary>
            public double Offset;
        }

        /// <summary>
        /// Delivers the conversion values of given units.
        /// </summary>
        /// <param name="src">Unit enum of the source.</param>
        /// <param name="dest">Unit enum of the destination.</param>
        /// <returns>The convserion as .Factor and .Offset.</returns>
        public static Conversion getConversion(UnitNamesEnum src, UnitNamesEnum dest)
        {
            double factor = 1d;
            double offset = 0d;

            if (GetUnitCategory(src) != GetUnitCategory(dest))
            {
                factor = double.NaN;
                offset = double.NaN;
            }
            else
            {
                if (src == dest)
                {
                    factor = 1.0;
                    offset = 1.0;
                }
                else
                {
                    double factorSrc = 1d / ((ConversionAttribute)typeof(UnitNamesEnum).GetField(Enum.GetName(typeof(UnitNamesEnum), src))
                                    .GetCustomAttributes(typeof(ConversionAttribute), false)[0]).Conversion[1];
                    double offsetSrc = -((ConversionAttribute)typeof(UnitNamesEnum).GetField(Enum.GetName(typeof(UnitNamesEnum), src))
                                    .GetCustomAttributes(typeof(ConversionAttribute), false)[0]).Conversion[0];

                    double factorDest = ((ConversionAttribute)typeof(UnitNamesEnum).GetField(Enum.GetName(typeof(UnitNamesEnum), dest))
                                   .GetCustomAttributes(typeof(ConversionAttribute), false)[0]).Conversion[1];
                    double offsetDest = ((ConversionAttribute)typeof(UnitNamesEnum).GetField(Enum.GetName(typeof(UnitNamesEnum), dest))
                                    .GetCustomAttributes(typeof(ConversionAttribute), false)[0]).Conversion[0];
                    factor = factorSrc * factorDest;
                    offset = offsetSrc + offsetDest;
                }
            }

            return new Conversion { Factor = factor, Offset = offset };
        }

        /// <summary>
        /// Converts a value of a given source to a destination unit (enum).
        /// </summary>
        /// <param name="Value">Value to be converted from a source to a destination unit (enum).</param>
        /// <param name="src">Unit enum of the source.</param>
        /// <param name="dest">Unit enum of the destination.</param>
        /// <returns>Converted value.</returns>
        public static double ConvertByUnits(double Value, UnitNamesEnum src, UnitNamesEnum dest)
        {
            Conversion c = getConversion(src, dest);
            return (c.Factor * Value + c.Offset);
        }
    }
}
