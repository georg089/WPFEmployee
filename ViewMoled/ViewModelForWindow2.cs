using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFEmployee.Model;

namespace WPFEmployee.ViewMoled
{
    class ViewModelForWindow2 
    {
        public ObservableCollection<Employee> _emp = new ObservableCollection<Employee>();

      

        public ObservableCollection<Employee> SelectedEmployee
        {
            get { return _emp; }
            set
            {
                _emp = value;
               
            }
        }
        public ViewModelForWindow2()
        {
            _emp = Employee.GetEmployees();
            _emp = new ObservableCollection<Employee>(_emp.OrderByDescending(x => x.Total));
        }

        public ObservableCollection<Employee> GetEmployees()
        {
            return _emp;
        }

       
    }
}
