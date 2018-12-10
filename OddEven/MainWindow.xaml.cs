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

namespace OddEven
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

        private void Btn_CheckEven_Click(object sender, RoutedEventArgs e)
        {
            string input;
            input = tbx_NumberInput.Text;
            int number1;
            bool isNumber = int.TryParse(input, out number1);

            if (isNumber)
            {
                bool isEven = false;
                if (number1 % 2 == 0)
                    isEven = true;

                if (isEven)
                {
                    tbk_MessageBlock.Text = "Number is Even.";
                    tbk_MessageBlock.Background = Brushes.Green;
                    tbk_MessageBlock.Foreground = Brushes.White;
                }
                else
                {
                    tbk_MessageBlock.Text = "Number is Odd.";
                    tbk_MessageBlock.Background = Brushes.Red;
                    tbk_MessageBlock.Foreground = Brushes.White;
                }
            }
            else
                tbk_MessageBlock.Text = "Invalid. Please enter only numbers.";
        }

        private void Tbx_NumberInput_GotFocus(object sender, RoutedEventArgs e)
        {
            tbx_NumberInput.Clear();
        }
    }
}
