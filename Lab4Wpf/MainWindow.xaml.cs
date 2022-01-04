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

namespace Lab4Wpf
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
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resDouble1 = rateEuro * sumEuro;
            resSum1.Text = resDouble1.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivna = Convert.ToDouble(rate2.Text);
            double sumGrivna = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateGrivna * sumGrivna;
            resSum2.Text = resDouble2.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(rate3.Text);
            double sumDrama = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateDrama * sumDrama;
            resSum3.Text = resDouble3.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double ratelength1 = Convert.ToDouble(length1.Text);
            double resultDouble1 = ratelength1 * 0.0254;
            result.Text = resultDouble1.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double ratelength2 = Convert.ToDouble(length1.Text);
            double resultDouble2 = ratelength2 * 0.3048;
            result1.Text = resultDouble2.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double ratelength3 = Convert.ToDouble(length1.Text);
            double resultDouble3 = ratelength3 * 1609.34;
            result2.Text = resultDouble3.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double ratelength4 = Convert.ToDouble(length1.Text);
            double resultDouble4 = ratelength4 * 1066.8;
            result3.Text = resultDouble4.ToString();
        }
    }
}
