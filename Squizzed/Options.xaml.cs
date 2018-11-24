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

namespace Squizzed
{
    /// <summary>
    /// Logika interakcji dla klasy Options.xaml
    /// </summary>
    public partial class Options : Page
    {
        
        public Options()
        {
            InitializeComponent();
            
            
        }

        private void returnToMenu(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Menu());
        }

        private void addCard(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new addCardPage());
        }

        private void EditCard_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void EditCard_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(MainWindow.cardNumber == 0) { e.CanExecute = false; }
            else { e.CanExecute = true; }
        }
        private void DeleteCard_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void DeleteCard_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (MainWindow.cardNumber == 0) { e.CanExecute = false; }
            else { e.CanExecute = true; }
        }
        private void editCard(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new editCardPage());
        }
        private void deleteCard(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new deleteCardPage());
        }
    }
}
