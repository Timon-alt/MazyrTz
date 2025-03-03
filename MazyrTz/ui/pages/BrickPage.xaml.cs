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
    /// Interaction logic for BrickPage.xaml
    /// </summary>
    public partial class BrickPage : Page
    {
        public BrickPage()
        {
            InitializeComponent();
        }

        public void Brick_Calculate(object sender, RoutedEventArgs e)
        {
            double length_brick = Double.Parse(Length_brick.Text);
            double width_brick = Double.Parse(Width_brick.Text);
            double thickness_brick = Double.Parse(Thickness_brick.Text);
            string type_brick = Type_brick.Text;
            string masonry_brick = Masonry_brick.Text;
        }
    }
}
