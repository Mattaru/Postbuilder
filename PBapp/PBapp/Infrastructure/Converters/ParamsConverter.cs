using System;
using System.Globalization;
using System.Windows.Data;

namespace PBapp.Infrastructure.Converters
{
    class ParamsConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture) => values.Clone();


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture) => null;
    }
}
