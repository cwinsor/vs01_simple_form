
// Reference:
// https://app.pluralsight.com/player?course=enterprise-wpf-xaml-csharp-from-scratch&author=jesse-liberty&name=enterprise-wpf-xaml-csharp-from-scratch-m2&clip=0&mode=live

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

namespace vs01_simple_form_demo
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

        private void Save_button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name");
            sb.Append(full_name.Text);
            sb.Append("Gender");
            sb.Append((bool)male.IsChecked ? "Male" : "Female");
            sb.Append("Computers:");
            sb.Append((bool)laptop.IsChecked ? "laptop" : "");
            sb.Append((bool)desktop.IsChecked ? "desktop" : "");
            sb.Append((bool)server.IsChecked ? "server" : "");
            sb.Append("Job:");
            sb.Append(job.SelectedItem.ToString());
            sb.Append("Delivery Date");
            sb.Append(delivery_date.SelectedDate.ToString());

            MessageBox.Show(sb.ToString());





        }
    }
    
}
