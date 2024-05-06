using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace DC
{
    /// <summary>
    /// Interaction logic for WindowPlayScreen.xaml
    /// </summary>
    public partial class WindowPlayScreen : Window
    {
        private int counter = 0;
        
        public WindowPlayScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;

            CounterLabel.Content = "Ďugcookies: " + counter.ToString();
        }
    }
}
