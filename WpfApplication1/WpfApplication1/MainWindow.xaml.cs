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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double height = double.Parse(textBox1.Text);
            double weight = double.Parse(textBox2.Text);
            double BMI = weight * 10000 / (height * height);
            text.Text = "你的BMI數值是" + BMI.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
