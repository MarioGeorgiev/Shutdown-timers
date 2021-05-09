using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPFTimer
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

        private void Shutdown(object sender, RoutedEventArgs e)
        {
           
            ProcessStartInfo processStartInfo = GetProcess($"/s /t {GetSeconds()}");
            Process.Start(processStartInfo);
        }



        private void Abort(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo processStartInfo = GetProcess("/a");
            Process.Start(processStartInfo);
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            ProcessStartInfo processStartInfo = GetProcess($"/r /t {GetSeconds()}");
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            Process.Start(processStartInfo);
        }

        private static ProcessStartInfo GetProcess(string command)
        {
            var processStartInfo = new ProcessStartInfo("shutdown",command );
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;
            return processStartInfo;
        }

        private int GetSeconds()
        {
            var  selectedValue = timeList.SelectionBoxItem.ToString();
            int time = int.Parse(selectedValue.TrimEnd('m', 'h'));
            if (selectedValue.EndsWith("h"))
            {
                time *= 60 * 60;
            }
            else
            {
                time *= 60;
            }
            
            return time;
            
        }


    }
}
