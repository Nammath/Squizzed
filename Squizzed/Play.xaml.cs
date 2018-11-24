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
    /// Logika interakcji dla klasy Play.xaml
    /// </summary>
    public partial class Play : Page
    {
        bool previousAnswerWasPositive = false;

        public Play()
        {
            InitializeComponent();
            showQuestion(MainWindow.gameNumber);

        }
        public void NextQuestion(object sender, RoutedEventArgs e)
        {
            int positiveAnswerPosition = 0;
            

            if (firstAnswerRadioButton.IsChecked == true) { positiveAnswerPosition = 0; }
            else if (secondAnswerRadioButton.IsChecked == true) { positiveAnswerPosition = 1; }
            else if (thirdAnswerRadioButton.IsChecked == true) { positiveAnswerPosition = 2; }
            else if (fourthAnswerRadioButton.IsChecked == true) { positiveAnswerPosition = 3; }

            if(MainWindow.deck.ListOfCards[MainWindow.gameNumber].GetAnswer(positiveAnswerPosition).GetResult() == true)
            {
                MainWindow.score.GivePoint();
                previousAnswerWasPositive = true;
            }
            else { previousAnswerWasPositive = false; }

            //MessageBox.Show(MainWindow.score.GetScore().ToString());
            MainWindow.gameNumber++;
            if(MainWindow.gameNumber < MainWindow.cardNumber)
            {
                showQuestion(MainWindow.gameNumber);
            }
            else
            {
                this.NavigationService.Navigate(new EndGamePage());
            }
            
        }

        public void PrevQuestion(object sender, RoutedEventArgs e)
        {
            
            if(previousAnswerWasPositive == true)
            {
                MainWindow.score.TakePoint();
            }
            MainWindow.gameNumber--;
            showQuestion(MainWindow.gameNumber);
        }

        private void showQuestion(int position)
        {
            questionTextBox.Text = MainWindow.deck.ListOfCards[position].GetQuestion();

            firstAnswerTextBox.Text = MainWindow.deck.ListOfCards[position].GetAnswer(0).GetContents();
            secondAnswerTextBox.Text = MainWindow.deck.ListOfCards[position].GetAnswer(1).GetContents();
            thirdAnswerTextBox.Text = MainWindow.deck.ListOfCards[position].GetAnswer(2).GetContents();
            fourthAnswerTextBox.Text = MainWindow.deck.ListOfCards[position].GetAnswer(3).GetContents();

        }

        private void PreviousQuestion_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void PreviousQuestion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if(MainWindow.gameNumber == 0) { e.CanExecute = false; }         
            else { e.CanExecute = true; }
        }

    }
}
