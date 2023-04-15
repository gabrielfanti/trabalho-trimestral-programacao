using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Venda.Iterativa.Classes
{
    internal abstract class AbstractNotifyPropertieChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void SetField<T>(ref T field, T value, [CallerMemberName] string nameProperty = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaizePropertyChange(nameProperty);
            }
        }

        private void RaizePropertyChange(string nameProperty) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameProperty));
    }
}
