using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace DC
{
    /// <summary>
    /// Interaction logic for WindowPlayScreen.xaml
    /// </summary>
    public partial class WindowPlayScreen : Window
    {
        //private float score = 0.0f;
        private float counter = 0.0f;
        private float click = 1.0f;
        private DispatcherTimer timer;
        private DispatcherTimer refresh;
        public WindowPlayScreen()
        {
            InitializeComponent();
            InitializeTimer();
            Refresh();
        }
        private void Refresh()
        {
            refresh = new DispatcherTimer();
            refresh.Interval = TimeSpan.FromSeconds(0.05);
            refresh.Tick += Refresh_Tick;
            refresh.Start();
        }
        private void Refresh_Tick(object sender, EventArgs e)
        {
            counter += (int)0;
            CounterLabel.Content = "Ďugcookies: " + counter.ToString();
        }

        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); 
            timer.Tick += Timer_Tick; 
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            counter += (int)25; 
            CounterLabel.Content = "Ďugcookies: " + counter.ToString(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter += (int)click;
            //score += (int)5;

            CounterLabel.Content = "Ďugcookies: " + counter.ToString();

            ClickCounter.Content = "Click value: " + click.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (counter < 100)
            { }
            else if (counter >= 100)
            {
                //score  += 100;
                counter -= 100.0f;
                click *= 2f;
                ((Button)sender).IsEnabled = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (counter < 2500)
            {

            }
            else if (counter >= 2500)
            {
                //score += 2000;
                counter -= 1000.0f;
                click += counter *= 0.005f;
                ((Button)sender).IsEnabled = false;

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (counter < 5000) { }
            else if (counter >= 5000)
            {
                counter -= 5000;
                timer.Start();
                ((Button)sender).IsEnabled = false;
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
    }
}
