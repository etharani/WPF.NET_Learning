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

namespace First_WpfApp
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void sumbtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(value1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information");
                value1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(value2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information");
                value2.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(value1.Text, out n1).ToString());


            if (!double.TryParse(value1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information");
            }
            MessageBox.Show(double.TryParse(value2.Text, out n2).ToString());
            if (!double.TryParse(value2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information");
            }
            output.Text = (n1 + n2).ToString();
        }

        private void multibtn_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(value1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information");
                value1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(value2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information");
                value2.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(value1.Text, out n1).ToString());


            if (!double.TryParse(value1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information");
            }
            MessageBox.Show(double.TryParse(value2.Text, out n2).ToString());
            if (!double.TryParse(value2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information");
            }
            output.Text = (n1 * n2).ToString();

        }

        private void divbtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(value1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information");
                value1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(value2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information");
                value2.Focus();
                return;
            }
            double n1;
            double n2;
            MessageBox.Show(double.TryParse(value1.Text, out n1).ToString());


            if (!double.TryParse(value1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information");
            }
            MessageBox.Show(double.TryParse(value2.Text, out n2).ToString());
            if (!double.TryParse(value2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information");
            }
            output.Text = (n1 / n2).ToString();

        }

        private void subbtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(value1.Text))
            {
                MessageBox.Show("Please enter Number1", "Information");
                value1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(value2.Text))
            {
                MessageBox.Show("Please enter Number2", "Information");
                value2.Focus();
                return;
            }

            double n1;
            double n2;
            MessageBox.Show(double.TryParse(value1.Text, out n1).ToString());


            if (!double.TryParse(value1.Text, out n1))
            {
                MessageBox.Show("Please enter current Number1", "Information");
            }
            MessageBox.Show(double.TryParse(value2.Text, out n2).ToString());
            if (!double.TryParse(value2.Text, out n2))
            {
                MessageBox.Show("Please enter current Number2", "Information");
            }
            output.Text = (n1 - n2).ToString();
        }

    
    }
}
