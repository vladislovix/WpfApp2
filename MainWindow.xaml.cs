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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWindow1_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new UserControl1());
        }

        private void btnWindow2_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new UserControl2());
        }

        private void btnWindow3_Click(object sender, RoutedEventArgs e)
        {
           // frame.Navigate(new Window3());
        }

        private void btnWindow4_Click(object sender, RoutedEventArgs e)
        {
            //frame.Navigate(new Window4());
        }

        private void btnWindow5_Click(object sender, RoutedEventArgs e)
        {
            //frame.Navigate(new Window5());
        }

        private void btnWindow6_Click(object sender, RoutedEventArgs e)
        {
            //frame.Navigate(new Window6());
        }
    }
}
