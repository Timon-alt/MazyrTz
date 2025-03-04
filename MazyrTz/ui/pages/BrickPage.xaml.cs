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
using MazyrTz.logic;

namespace MazyrTz.ui.pages
{
    /// <summary>
    /// Interaction logic for BrickPage.xaml
    /// </summary>
    public partial class BrickPage : Page
    {
        private double bricks_amount;
        public BrickPage()
        {
            InitializeComponent();
        }

        public void Brick_Calculate(object sender, RoutedEventArgs e)
        {
            double length_wall = Double.Parse(Length_brick.Text);
            double width_wall = Double.Parse(Width_brick.Text);
            double thickness_wall = Double.Parse(Thickness_brick.Text);
            string type_brick = Type_brick.Text;
            string masonry_brick = Masonry_brick.Text;
            BrickCalculate bricks = new BrickCalculate();
            double amount = bricks.Calculate_Amount_Bricks(length_wall, width_wall, thickness_wall, type_brick);
            bricks_txtBlock.Text = $"{amount} ШТ. Кирпича";
            bricks_txtBlock.Visibility = Visibility.Visible;
            btnNext.Visibility = Visibility.Visible;
            bricks_amount = amount;
        }

        public void ToAdressPage(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdessPage(bricks_amount));
        }
    }
}
