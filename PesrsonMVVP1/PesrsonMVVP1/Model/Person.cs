using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesrsonMVVP1.Model
{
    class Person :  INotifyPropertyChanged
    {
        private string _Id;
        public string Id { get { return _Id; } set { _Id = value; OnPropertyChanged("ID"); } }
        private string _FName;
        public string FName { get { return _FName; } set { _FName = value; OnPropertyChanged("FName"); } }
        private string _SName;
        public string SName { get { return _SName; } set { _SName = value; OnPropertyChanged("SName"); } }
        private string _LName;
        public string LName { get { return _LName; } set { _LName = value; OnPropertyChanged("LName"); } }
        private string _Age;
        public string Age { get { return _Age; } set { _Age = value; OnPropertyChanged("Age"); } }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
