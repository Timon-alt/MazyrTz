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
    /// Interaction logic for BuildResPage.xaml
    /// </summary>
    public partial class BuildResPage : Page
    {
        public BuildResPage()
        {
            InitializeComponent();
        }

        public void Brick_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BrickPage());
        }
    }
}
