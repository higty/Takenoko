using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Chapter_0023
{
    public class MusicPlayer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Double _Volume = 0;
        public Double Volume
        {
            get { return _Volume; }
            set
            {
                if (_Volume == value) return;
                _Volume = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Volume)));
            }
        }

    }
}
