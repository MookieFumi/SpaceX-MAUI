using System.Globalization;

namespace SpaceXData.Converters;

public class BooleanToStyleConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is bool booleanValue)
        {
            return booleanValue ? (Style)Application.Current.Resources["SuccessLabelStyle"] : (Style)Application.Current.Resources["NoSuccessLabelStyle"];
        }
        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
