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

namespace FutureForecast
{
    /// <summary>
    /// Логика взаимодействия для Present_Forecast.xaml
    /// </summary>
    public partial class Present_Forecast : Window
    {
        public Present_Forecast()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow s = new MainWindow();
            s.Show();
        }

        private void BtnDollar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
