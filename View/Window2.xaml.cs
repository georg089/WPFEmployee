using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFEmployee.Model;
using WPFEmployee.ViewMoled;

namespace WPFEmployee.View
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        readonly ViewModelForWindow2 a = new ViewModelForWindow2();
        public Window2()
        {
            InitializeComponent();
            DataContext = a;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dg2.ItemsSource = a._emp.Take<Employee>(3);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dg2.ItemsSource = a._emp.Skip<Employee>(a.GetEmployees().Count - 5);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dg2.ItemsSource = a.GetEmployees();
        }
    }
}
