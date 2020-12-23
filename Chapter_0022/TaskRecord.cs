using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Chapter_0022
{
    public class TaskRecord : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private String _Title = "";
        private Int32 _Priority = 3;

        public String Title
        {
            get { return _Title; }
            set
            {
                if (_Title == value) return;
                _Title = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        }
        public String UserName { get; set; }
        public String Description { get; set; }
        public Int32 Priority
        {
            get { return _Priority; }
            set
            {
                if (_Priority == value) return;
                _Priority = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Priority)));
            }
        }
    }
}
