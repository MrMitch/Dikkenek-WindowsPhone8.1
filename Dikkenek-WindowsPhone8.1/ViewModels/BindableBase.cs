using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Dikkenek_WindowsPhone8._1.ViewModels
{
    public class BindableBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Membres

        public event PropertyChangedEventHandler PropertyChanged;

        public bool SetValue<T>(ref T target, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(target, value))
            {
                return false;
            }

            target = value;
            NotifyPropertyChanged(propertyName);

            return true;
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
