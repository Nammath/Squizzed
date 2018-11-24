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
    /// Logika interakcji dla klasy editCardPage.xaml
    /// </summary>
    public partial class editCardPage : Page
    {
        int position = 0;
        public editCardPage()
        {
            InitializeComponent();
            cardsListBox.Items.Clear();
            for(int i = 0; i < MainWindow.deck.ListOfCards.Count; i++)
            {
                cardsListBox.Items.Add(MainWindow.deck.ListOfCards[i].GetQuestion());
                
            }
        }

        private void Cofnij_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Options());
        }

        private void Zapisz_Click_1(object sender, RoutedEventArgs e)
        {
            Card tempCard = MainWindow.deck.GetCard(position);

            tempCard.SetQuestion(questionTextBox.Text);
            tempCard.SetAnswer(answerOneTextBox.Text, false, 0);
            tempCard.SetAnswer(answerTwoTextBox.Text, false, 1);
            tempCard.SetAnswer(answerThreeTextBox.Text, false, 2);
            tempCard.SetAnswer(answerFourTextBox.Text, false, 3);

            if(radioOne.IsChecked == true) { tempCard.SetAnswer(answerOneTextBox.Text, true, 0); }
            else if (radioTwo.IsChecked == true) { tempCard.SetAnswer(answerTwoTextBox.Text, true, 1); }
            else if (radioThree.IsChecked == true) { tempCard.SetAnswer(answerThreeTextBox.Text, true, 2); }
            else if (radioFour.IsChecked == true) { tempCard.SetAnswer(answerFourTextBox.Text, true, 3); }

            MainWindow.deck.SetCard(position, tempCard);

        }

        private void cardsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            position = cardsListBox.SelectedIndex;

            Card tempCard = MainWindow.deck.ListOfCards[position];

            questionTextBox.Text = tempCard.GetQuestion();
            answerOneTextBox.Text = tempCard.GetAnswer(0).GetContents();
            answerTwoTextBox.Text = tempCard.GetAnswer(1).GetContents();
            answerThreeTextBox.Text = tempCard.GetAnswer(2).GetContents();
            answerFourTextBox.Text = tempCard.GetAnswer(3).GetContents();

            List<Answer> tempList = tempCard.GetAnswers();
            if (tempList[0].GetResult() == true) { radioOne.IsChecked = true; }
            if (tempList[1].GetResult() == true) { radioTwo.IsChecked = true; }
            if (tempList[2].GetResult() == true) { radioThree.IsChecked = true; }
            if (tempList[3].GetResult() == true) { radioFour.IsChecked = true; }
        }
    }
}
