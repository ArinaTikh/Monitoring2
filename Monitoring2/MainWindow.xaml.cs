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

namespace Monitoring2
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

        private void Max_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Min_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void timemax_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void timemin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Date_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void chek_Click(object sender, RoutedEventArgs e)
        {
            DateTime time = Date();
        }
    }
}
