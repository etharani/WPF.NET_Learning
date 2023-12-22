using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
using winforms=System.Windows.Forms; 
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Windows.xaml
    /// </summary>
    public partial class Windows : Window
    {
        public Windows()
        {
            InitializeComponent();
        }

        private void browerbtn_Click(object sender, RoutedEventArgs e)
        {
            // FolderBrowserDialog dialog = new FolderBrowserDialog();
            winforms.FolderBrowserDialog dialog = new winforms.FolderBrowserDialog();
            dialog.InitialDirectory = "D:.NET_WPF";
            dialog.ShowDialog();
        //  Note    MessageBox.Show("");
        }
    }
}
