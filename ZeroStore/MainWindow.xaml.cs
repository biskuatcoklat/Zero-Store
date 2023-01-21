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
using ZeroStore.ViewModels;

namespace ZeroStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BarangViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new BarangViewModel();
            this.DataContext = viewModel;
        }

        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.Home();
        }

        private void Button_Click_ProsesData(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.ProsesBarang();
            viewModel = new BarangViewModel();
            this.DataContext = viewModel;
        }

        private void Button_Click_DataBarang(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.DataBarang();
            viewModel = new BarangViewModel();
            this.DataContext = viewModel;
        }

        private void Button_Click_Konsumen(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.Konsumen();
            viewModel = new BarangViewModel();
            this.DataContext = viewModel;
        }

        private void Button_Click_Transaksi(object sender, RoutedEventArgs e)
        {
            Main.Content = new Views.Transaksi();
            viewModel = new BarangViewModel();
            this.DataContext = viewModel;
        }
    }
}
