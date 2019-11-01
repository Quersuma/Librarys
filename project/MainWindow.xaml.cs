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

namespace WpfApp20
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

    
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FR.Navigate(new insert());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FR.Navigate(new ReadTicket());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FR.Navigate(new GetBooks());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FR.Navigate(new BooksBD());
        }

        private void WindowMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FR.Navigate(new BdReaders());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            FR.Navigate(new Page1());
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FR.Navigate(new Page2());
        }
    }
}
