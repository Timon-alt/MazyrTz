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

namespace MazyrTz
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

        private void NalogButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу "Налог"
            MainFrame.Navigate(new Uri("ui/pages/NalogPage.xaml", UriKind.Relative));
        }

        private void GraphButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу "График"
            MainFrame.Navigate(new Uri("ui/pages/GraphicPage.xaml", UriKind.Relative));
        }

        private void RawMaterialButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу "Сырьё"
            MainFrame.Navigate(new Uri("ui/pages/BuildResPage.xaml", UriKind.Relative));
        }
    }
}
