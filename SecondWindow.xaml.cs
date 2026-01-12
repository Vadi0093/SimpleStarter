using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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

namespace SimpleStarter
{
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();

            // Ustawienie okienka na środku prawej krawędzi ekranu
            int screenWidth = (int)SystemParameters.PrimaryScreenWidth;
            int screenHeight = (int)SystemParameters.PrimaryScreenHeight;
            Left = screenWidth - Width;
            Top = (screenHeight - Height) / 2;
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Jesteś pewny?", "SimpleStarter", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void RunSimpleCalc(object sender, RoutedEventArgs e)
        {
            Process.Start("Apps\\Calc\\SimpleCalc.exe");
        }

        private void RunSimpleNotePad(object sender, RoutedEventArgs e)
        {

        }

        private void RunSimpleStopWatch(object sender, RoutedEventArgs e)
        {

        }

        private void RunSimplePixelDraw(object sender, RoutedEventArgs e)
        {

        }

        private void RunBrowser(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.com",
                UseShellExecute = true
            });
        }
    }
}