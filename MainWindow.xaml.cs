using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleStarter
{
    public partial class MainWindow : Window
    {
        // Nowy obiekt klasy drugiego okna
        SecondWindow secondWindow = new SecondWindow();

        public MainWindow()
        {
            InitializeComponent();

            // Ustawienie okienka na środku prawej krawędzi ekranu
            int screenWidth = (int)SystemParameters.PrimaryScreenWidth;
            int screenHeight = (int)SystemParameters.PrimaryScreenHeight;
            Left = screenWidth - Width;
            Top = (screenHeight - Height) / 2;
        }

        private void OpenSecondWindow(object sender, MouseEventArgs e)
        {
            int screenWidth = (int)SystemParameters.PrimaryScreenWidth;
            if (!secondWindow.IsVisible)
            {
                secondWindow.Show();
                Left = screenWidth - Width - secondWindow.Width;
                Icon.Text = "❯";
            }
            else
            {
                secondWindow.Hide();
                Left = screenWidth - Width;
                Icon.Text = "❮";
            }
        }
    }
}