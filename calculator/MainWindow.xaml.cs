using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
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
        private void Sum(object sender, RoutedEventArgs e)
        {
            
        }

        private void Reduce(object sender, RoutedEventArgs e)
        {
            ResutNumber.Text = Convert.ToString(Convert.ToInt16(FirstNumber.Text) - Convert.ToInt16(SecondNumber.Text));
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(SecondNumber.Text) != 0)
                ResutNumber.Text = Convert.ToString(Convert.ToInt16(FirstNumber.Text) / Convert.ToInt16(SecondNumber.Text));
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {

        }
    }
}