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
    /// Logika interakcji dla klasy Menu.xaml
    /// </summary>
    /// 
    
    public partial class Menu : Page
    {
        
        public Menu()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Play());
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Options());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void PlayButton_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void PlayButton_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(MainWindow.cardNumber == 0) { e.CanExecute = false; }
            else { e.CanExecute = true; }
        }
    }
}
