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
using System.Runtime.InteropServices;
using System.Management;
using System.Diagnostics;


namespace pc_shutdown_timer
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

           

    void Shutdown()
    {
        Process.Start("shutdown.exe", "-s -t 60");
    }

    void Cancelshutdown()
        {
            Process.Start("shutdown.exe", "-a");
        }

    void Restart()
        {
            Process.Start("shutdown.exe", "-r  -t 60");
        }

    private void shutdown_Click(object sender, RoutedEventArgs e)
        {
            Shutdown();
        }

    private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Cancelshutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }
    }


}
