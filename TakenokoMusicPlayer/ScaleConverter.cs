using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace TakenokoMusicPlayer
{
    public class ScaleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var x = (Double)value;
            return x * 100;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var x = (Double)value;
            return x / 100;
        }
    }
}
