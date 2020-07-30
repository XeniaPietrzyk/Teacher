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

namespace Teacher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MenuPage menuPage = new MenuPage();
            mainFrame.NavigationService.Navigate(menuPage);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void btnLearn_Click(object sender, RoutedEventArgs e)
        //{
        //    LearnWindow learnWindow = new LearnWindow();
        //    learnWindow.Owner = this;
        //    learnWindow.Show();

        //    //MainFrame.Content = new Page1();
        //    //MainFrame.Navigate(new Page1());
        //    //MainFrame.Source = new Uri("https://www.e-ang.pl/nauka.php", UriKind.Absolute);
        //    //MainFrame.Navigate(new System.Uri("Page1.xaml", UriKind.RelativeOrAbsolute));
        //}
    }
}
