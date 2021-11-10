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

namespace lab4WpfApp1
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
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateE.Text);
            double sumDollar = Convert.ToDouble(sumE.Text);
            double resDouble = rateDollar * sumDollar;
            resSumE.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateG.Text);
            double sumDollar = Convert.ToDouble(sumG.Text);
            double resDouble = rateDollar * sumDollar;
            resSumG.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rateD.Text);
            double sumDollar = Convert.ToDouble(sumD.Text);
            double resDouble = rateDollar * sumDollar;
            resSumD.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double count = Convert.ToDouble(inch.Text);
            double res = count * 0.025;
            inchM.Text = res.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double count = Convert.ToDouble(foot.Text);
            double res = count * 0.3;
            footM.Text = res.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double count = Convert.ToDouble(miles.Text);
            double res = count * 1609.34;
            milesM.Text = res.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double count = Convert.ToDouble(ver.Text);
            double res = count * 1067;
            verM.Text = res.ToString();
        }
    }
}
