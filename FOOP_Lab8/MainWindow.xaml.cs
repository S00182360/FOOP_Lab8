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
            Number1 = r.Next(0, 20);
            Number2 = r.Next(0, 20);
        }
    }
}
