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
using MazyrTz.database;

namespace MazyrTz.ui.pages
{
    /// <summary>
    /// Логика взаимодействия для AdessPage.xaml
    /// </summary>
    public partial class AdessPage : Page
    {
        private double cost;
        private string adress;
        private double bricks_amount;

        public AdessPage(double bricks_amountt)
        {
            InitializeComponent();
            double cenaa = Math.Round(bricks_amount * 30.6 + 500);
            Cena.Text = $"Итого: {cenaa} руб";
            cost = cenaa;
            bricks_amount = bricks_amountt;
        }

        public async void Otpravit_click(object sender, RoutedEventArgs e)
        {
            try
            {
                adress = adress_txtBlock.Text;
                var rawMaterials = new RawMaterials()
                {
                    bricks_count = bricks_amount,
                    cost = cost,
                    adress = adress
                };
                await App.supabase.From<RawMaterials>().Insert(rawMaterials);
                MessageBox.Show("Информация успешна обработана", "Сообщение", MessageBoxButton.OK);
                NavigationService.Navigate(new BuildResPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении данных: {ex.Message}");
            }
            

        }
    }
}
