using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WPFEmployee.Model
{


    [Serializable] class Employee : INotifyPropertyChanged
    {
        

        private string _fio;
        private string _position;
        private bool _fixed;
        private bool _nfixed;
        private int _rate;
        private int _total;
        private int _time;
      
         
      
        public static ObservableCollection<Employee> GetEmployees()
        {

            return _ = SerialAndDiserial.Deserialize(PATH);
        }
        

        public int Time
        {
            get { return _time; }
            set
            {
                if (_time == value)
                {
                    return;
                }
                _time = value;
                OnPropertyChanged("Time");
                OnPropertyChanged("Total");
            }

        }

        public string Fio
        {
            get { return _fio; }
            set
            {
                if (_fio == value)
                {
                    return;
                }
                _fio = value;
                OnPropertyChanged("Fio");
            }
        }
       
        public string Position
        {
            get { return _position; }
            set
            {
                if (_position == value)
                {
                    return;
                }
                _position = value;
                OnPropertyChanged("Position");
            }
        }
        public bool Fixed
        {
            get { return _fixed; }
            set
            {
                if (_fixed == value)
                {
                    return;
                }
                _fixed = value;
                if (_fixed == true)
                {
                    _nfixed = false;
                }
                if (_fixed == false)
                {
                    _nfixed = true;
                }
                OnPropertyChanged("NFixed");
                OnPropertyChanged("Fixed");
                OnPropertyChanged("Total");
            }
        }
        public bool NFixed
        {
            get { return _nfixed; }
            set
            {
                if (_nfixed == value)
                {
                    return;
                }
                _nfixed = value;
                if (_nfixed == true)
                {
                    _fixed = false;
                }
                if (_nfixed == false)
                {
                    _fixed = true;
                }
                OnPropertyChanged("Fixed");
                OnPropertyChanged("NFixed");
                OnPropertyChanged("Total");
            }
        }
        public int Rate
        {
            get { return _rate; }
            set
            {
                if (_rate == value)
                {
                    return;
                }
                _rate = value;
                OnPropertyChanged("Rate");
                OnPropertyChanged("Total");
            }
        }

        public int Total
        {
            get
            {
                if (NFixed == true)
                {
                    return (_time * _rate);
                }
                else return (_rate);
            }
            set
            {

                if (NFixed == true)
                {
                    _total = _time * _rate;
                }
                else _total = _rate;
                OnPropertyChanged("Total");
            }
        }
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;
       
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private  static string PATH = $"{Environment.CurrentDirectory}\\DataFile.dat";

        public static void Save(ObservableCollection<Employee> employees)
        {
            SerialAndDiserial.Serialize(employees, PATH);
        }
    }
}
