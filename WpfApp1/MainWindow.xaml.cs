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

        private void btn_hamburgerMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(btn_hamburgerMenu.Width != 60)
            {
                GridLength gridLength = new GridLength(70, GridUnitType.Pixel);
                grdClmn_menu.Width = gridLength;

                lbl_logoyazi.Visibility = Visibility.Hidden;
                lbl_menu1.Visibility = Visibility.Hidden;
                lbl_menu2.Visibility = Visibility.Hidden;
                lbl_menu3.Visibility = Visibility.Hidden;
                lbl_menu4.Visibility = Visibility.Hidden;
                lbl_menu5.Visibility = Visibility.Hidden;
                menu_alt_resim.Visibility = Visibility.Hidden;
                btn_hamburgerMenu.Width = 60;
                lbl_logoyazi.Width = 0;
            }
            else
            {
                GridLength gridLength = new GridLength(220, GridUnitType.Pixel);
                grdClmn_menu.Width = gridLength;

                lbl_logoyazi.Visibility = Visibility.Visible;
                lbl_menu1.Visibility = Visibility.Visible;
                lbl_menu2.Visibility = Visibility.Visible;
                lbl_menu3.Visibility = Visibility.Visible;
                lbl_menu4.Visibility = Visibility.Visible;
                lbl_menu5.Visibility = Visibility.Visible;
                menu_alt_resim.Visibility = Visibility.Visible;
                btn_hamburgerMenu.Width = 100;
                lbl_logoyazi.Width = 150;
            }
            
        }
    }
}
