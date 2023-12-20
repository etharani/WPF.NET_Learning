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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool running = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checkbtn_Click(object sender, RoutedEventArgs e)
        {
            if (running)
            {
                //stop 
                txtblock.Text = "Stoped";
                checkbtn.Content = "Run";
            }
            else
            {
                //run
                txtblock.Text = "Running";
                checkbtn.Content = "Stop";

            }
            running = !running;
        }
    }
}
