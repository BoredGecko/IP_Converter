using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace IP_Conventer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoTo_Pv4Info_Click(object sender, RoutedEventArgs e)
        {
            Window window = new IPv4Info();
            window.Show();
        }

        private void GoToIPv6Info_Click(object sender, RoutedEventArgs e)
        {
            Window window = new IPv6Info();
            window.Show();
        }
    }
}
