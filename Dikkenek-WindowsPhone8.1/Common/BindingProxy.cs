using Windows.UI.Xaml;

namespace Dikkenek_WindowsPhone8._1.Common
{
    public class BindingProxy : DependencyObject
    {
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register(
            "Data",
            typeof(object),
            typeof(BindingProxy),
            new PropertyMetadata(null));

        public object Data
        {
            get { return GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }
    }
}
