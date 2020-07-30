using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnLearn_Click(object sender, RoutedEventArgs e)
        {
            LearnPage learnPage = new LearnPage();
            this.NavigationService.Navigate(learnPage);
        }

        private void btnAddLibrary_Click(object sender, RoutedEventArgs e)
        {
            AddLibraryPage addLibraryPage = new AddLibraryPage();
            this.NavigationService.Navigate(addLibraryPage);
        }

        private void btnAddWord_Click(object sender, RoutedEventArgs e)
        {
            AddWordPage addWordPage = new AddWordPage();
            this.NavigationService.Navigate(addWordPage);
        }
    }
}
