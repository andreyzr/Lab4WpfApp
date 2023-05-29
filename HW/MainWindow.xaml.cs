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

namespace Ex_01
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            double resDouble = rateDollar * sumDollar;
            resSum1.Text= resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEur = Convert.ToDouble(rate2.Text);
            double sumEur = Convert.ToDouble(sum2.Text);
            double resEur = rateEur * sumEur;
            resSum2.Text = resEur.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHry = Convert.ToDouble(rate3.Text);
            double sumHry = Convert.ToDouble(sum3.Text);
            double resHry = rateHry * sumHry;
            resSum3.Text = resHry.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDra = Convert.ToDouble(rate4.Text);
            double sumDra = Convert.ToDouble(sum4.Text);
            double resDra = sumDra * sumDra;
            resSum4.Text = resDra.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double distanceInch = Convert.ToDouble(distance1.Text);
            double ratio= 0.025;
            double resInch = distanceInch * ratio;
            resDistance1.Text = resInch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double distanceFoot = Convert.ToDouble(distance2.Text);
            double ratio = 0.3;
            double resFoot = distanceFoot * ratio;
            resDistance2.Text = resFoot.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double distanceMile = Convert.ToDouble(distance3.Text);
            double ratio = 1609.34;
            double resMile = distanceMile * ratio;
            resDistance3.Text = resMile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double distanceVerst = Convert.ToDouble(distance4.Text);
            double ratio = 1066.8;
            double resVerst = distanceVerst * ratio;
            resDistance4.Text = resVerst.ToString();
        }
    }
}
