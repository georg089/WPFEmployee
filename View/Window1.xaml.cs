using System;
using System.Windows;
using WPFEmployee.ViewMoled;

namespace WPFEmployee.View
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ViewModelForWindow1 a = new ViewModelForWindow1();
        public Window1()
        {
            InitializeComponent();
           
            DataContext = a;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            a.Close();
        }
    }
}
