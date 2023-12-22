using Microsoft.Win32;
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

        private void btnfile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            //  file.ShowDialog();
            //filter
              file.Filter = "C# Soure file | *.cs";
            //InitialDirectory
            //  file.InitialDirectory = "c:\\";
            //tittle
            file.Title = "C# CS files";
            //Multiselection to files
            file.Multiselect = true;
          bool? success = file.ShowDialog();
            if(success == true)
            {
                //method 1
                //   String path= file.FileName;
                //     txtfile.Text = path;
                // multi files open to use for  String path= file.FileNames; (S)
                //method 2

                String safe = file.SafeFileName;
                txtfile.Text = safe;

            }
            else { }
        }
    }
}
