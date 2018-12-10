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

namespace FOOP_Lab8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Random r = new Random();
        public int Number1 { get; set; }
        public int Number2 { get; set; }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_StartGame_Click(object sender, RoutedEventArgs e)
        {
            Number1 = r.Next(1, 21);
            Number2 = r.Next(1, 21);
            tbk_Initial.Text = "Number : " + Number1.ToString();
            tbk_Number2.Text = Number2.ToString();
            tbk_WinLoose.Text = "";
        }

        private void Btn_Guess_Click(object sender, RoutedEventArgs e)
        {
            bool isBigger = false;
            if (Number1 <= Number2)
                isBigger = true;
            else
                isBigger = false;
            bool selectedBigger = rad_Bigger.IsChecked.Equals(true);
            bool selectedSmaller = rad_Small.IsChecked.Equals(true);
            if ((isBigger && selectedBigger) || (selectedSmaller && !isBigger))
                tbk_WinLoose.Text = "You win!";
            else
                tbk_WinLoose.Text = "You Loose";
            Number1 = r.Next(1, 21);
            Number2 = r.Next(1, 21);
            tbk_Initial.Text = Number1.ToString();
            //This line of code was used in development to check 
            //above logic worked.
            tbk_Number2.Text = Number2.ToString();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbk_Initial.Text = "Press 'Start Game' to begin.";
            tbk_WinLoose.Text = "";
            tbk_Instruct.Text = "Is the next number bigger or smaller?";
        }
    }
}
