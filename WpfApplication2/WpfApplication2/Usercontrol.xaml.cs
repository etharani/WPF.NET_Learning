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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Usercontrol.xaml
    /// </summary>
    public partial class Usercontrol : Window
    {
        public Usercontrol()
        {
            InitializeComponent();
        }

        private void btnmessagebox_Click(object sender, RoutedEventArgs e)
        {
            //    MessageBox.Show("Hi welcome to my page!","Welcome",MessageBoxButton.OK,MessageBoxImage.Information);
            MessageBoxResult result= MessageBox.Show("Hi welcome to my page!", "Welcome", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                textbox.Text = "True";
            }
            else
            {
                textbox.Text = "False";
            }
        }
    }
}
