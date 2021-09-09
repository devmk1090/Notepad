using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Notepad
{
    //view(xaml) 와 model 을 바인딩을 시켜서 화면에 보여주게 되는데, 바인딩된 값이 바뀔때마다
    //변화를 인지하여 백단의 값을 자동으로 바뀌게 해주는 역할
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged<T>(ref T property, T value, [CallerMemberName] String propertyName = "")
        {
            property = value;
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
