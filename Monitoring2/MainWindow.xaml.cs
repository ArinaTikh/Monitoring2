using System;
using System.Windows;
using System.Windows.Controls;

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
        private void rezult_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void chek_Click(object sender, RoutedEventArgs e)
        {
            int maxim = Convert.ToInt32(Max);
            int minim = Convert.ToInt32(Min);

            int data1 = Convert.ToInt32(Date);
            DateTime dateTime = new DateTime(data1);

            int temperature = Convert.ToInt32(temperate);
            int[] zhach = new int[maxim];
            int[] zhachmin = new int[minim];
            int[] temp = new int[temperature];
            foreach (int a in temp)
            {
                if (a > maxim || a < minim)
                {
                    dateTime.AddMinutes(10);
                }
                MessageBox.Show("Превышение температуры");
            }


        }

       
    }
}
