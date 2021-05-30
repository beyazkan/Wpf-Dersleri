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
using WpfApp1.library;
using WpfApp1.usercontrols;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ucLoad ucLoad;

        public MainWindow()
        {
            InitializeComponent();
            ucLoad = new ucLoad();
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btn_kapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SagUst_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void btn_kucult_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_KitapListesi_Click(object sender, RoutedEventArgs e)
        {
            ucLoad.uc_Load(content, new kitapListesi());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ucLoad.uc_Load(content, new kitapListesi());
            DBConnection.connectionTest();
            version.Content = DBConnection.connectionState;
        }

        private void btn_tamEkran_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
                mainWindow.Margin = new Thickness(0,0,0,0);
            }
            else
            {
                this.WindowState = WindowState.Normal;
                mainWindow.Margin = new Thickness(15, 15, 15, 15);
            }
            
        }
    }
}
