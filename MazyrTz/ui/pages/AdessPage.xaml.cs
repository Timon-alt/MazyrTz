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

namespace MazyrTz.ui.pages
{
    /// <summary>
    /// Логика взаимодействия для AdessPage.xaml
    /// </summary>
    public partial class AdessPage : Page
    {
        private double cena;
        private string adress;

        public AdessPage(double bricks_amount)
        {
            InitializeComponent();
            double cenaa = Math.Round(bricks_amount * 30.6 + 500);
            Cena.Text = $"Итого: {cenaa} руб";
            cena = cenaa;
        }

        public void Otpravit_click(object sender, RoutedEventArgs e)
        {
            Cena.Visibility = Visibility.Visible;
            MessageBox.Show("Информация успешна обработана", "Сообщение", MessageBoxButton.OK);
            NavigationService.Navigate(new BuildResPage());

        }
    }
}
