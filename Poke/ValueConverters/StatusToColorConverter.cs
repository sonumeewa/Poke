﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace Poke
{
    public class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case NonVolatileStatus.BadPoison:
                case NonVolatileStatus.Poison:
                    return Types.Poison.GetColorHex();

                case NonVolatileStatus.Burn:
                    return Types.Fire.GetColorHex();

                case NonVolatileStatus.Freeze:
                    return Types.Ice.GetColorHex();

                case NonVolatileStatus.Paralysis:
                    return Types.Electric.GetColorHex();

                case NonVolatileStatus.Sleep:
                    return Types.Steel.GetColorHex();

                default:
                    return "#00000000";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}