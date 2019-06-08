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

namespace FutureForecast
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

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thank you for using our program!\nEmail: kartoplyk@gmail.com\nPh:+380731694802\n\tThanks a lot :)");
            Close();
        }

        private void BtnPresentForecast_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Present_Forecast pr = new Present_Forecast();
            pr.Show();
        }

        private void BtnHistoryOfChangingForecast_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ForecastHistory hist = new ForecastHistory();
            hist.Show();
        }
    }
}
