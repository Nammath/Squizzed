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
    /// Logika interakcji dla klasy deleteCardPage.xaml
    /// </summary>
    public partial class deleteCardPage : Page
    {
        int position = 0;
        public deleteCardPage()
        {
            InitializeComponent();
            cardsListBox.Items.Clear();
            for (int i = 0; i < MainWindow.deck.ListOfCards.Count; i++)
            {
                cardsListBox.Items.Add(MainWindow.deck.ListOfCards[i].GetQuestion());

            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Options());
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.deck.DeleteCard(position);
            cardsListBox.Items.Clear();
            for (int i = 0; i < MainWindow.deck.ListOfCards.Count; i++)
            {
                cardsListBox.Items.Add(MainWindow.deck.ListOfCards[i].GetQuestion());

            }
        }

        private void cardsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            position = cardsListBox.SelectedIndex;
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(cardsListBox.SelectedItem != null) { e.CanExecute = true; }
            else { e.CanExecute = false; }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
