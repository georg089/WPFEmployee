using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WPFEmployee.Model;
using WPFEmployee.View;

namespace WPFEmployee.ViewMoled
{
    class ViewModelForWindow1 : INotifyPropertyChanged
    {
        public ObservableCollection<Employee> _emp = new ObservableCollection<Employee>();

       
        public ObservableCollection<Employee> SelectedEmployee
        {
            get { return _emp; }
            set
            {
                _emp = value;
                OnPropertyChanged("SelectedEMP");
            }
        }


        public ViewModelForWindow1()
        {
            _emp = Employee.GetEmployees();
           
        }

      
        public void Close ()
        {
            Employee.Save(_emp);
            
        }

       
        public event PropertyChangedEventHandler PropertyChanged;
      
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
