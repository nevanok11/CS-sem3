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
        private double firstnum, secondnum, resultnum;
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool InputValidation()
        {
            if (double.TryParse(FirstNum.Text, out firstnum) && double.TryParse(SecondNum.Text, out secondnum))
                return true;
            else
            {
                MessageBox.Show("Введены некорректные значения","Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);

                FirstNum.Text = string.Empty;
                SecondNum.Text = string.Empty;

                return false;
            }
        }
    }
}