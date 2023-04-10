using System.Globalization;

namespace BugReproduction;

public class StringIsNullOrEmptyConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value switch
		{
			null => true,
			string str => string.IsNullOrEmpty(str),
			var _ => throw new ArgumentException("Value must be a string")
		};
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
