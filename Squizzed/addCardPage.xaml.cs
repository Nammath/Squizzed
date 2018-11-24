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
    /// Logika interakcji dla klasy addCardPage.xaml
    /// </summary>
    public partial class addCardPage : Page
    {
        public addCardPage()
        {
            InitializeComponent();
        }

        private void sendAnswer(object sender, RoutedEventArgs e)
        {
            string question = questionTextBox.Text;
            string firstAnswer = answerOne.Text;
            string secondAnswer = answerTwo.Text;
            string thirdAnswer = answerThree.Text;
            string fourthAnswer = answerFour.Text;

            Answer firstAnswerObject = new Answer(firstAnswer, false);
            Answer secondAnswerObject = new Answer(secondAnswer, false);
            Answer thirdAnswerObject = new Answer(thirdAnswer, false);
            Answer fourthAnswerObject = new Answer(fourthAnswer, false);

            if (firstRadio.IsChecked == true) { firstAnswerObject.SetResult(true); }
            else if (secondRadio.IsChecked == true) { secondAnswerObject.SetResult(true); }
            else if (thirdRadio.IsChecked == true) { thirdAnswerObject.SetResult(true); }
            else if (fourthRadio.IsChecked == true) { fourthAnswerObject.SetResult(true); }


            List<Answer> answerList = new List<Answer>();
            answerList.Add(firstAnswerObject);
            answerList.Add(secondAnswerObject);
            answerList.Add(thirdAnswerObject);
            answerList.Add(fourthAnswerObject);

            Card card = new Card(question, answerList);
            MainWindow.deck.AddCard(card);
            MainWindow.cardNumber++;

            this.NavigationService.Navigate(new Options());
            //MessageBox.Show(MainWindow.deck.GetCard(0).GetQuestion());
        }
        private void goBack(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Options());
        }

        private void AddCard_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void AddCard_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            bool questionIs = false;
            bool answersAre = false;
            bool radiosAre = false;
            if (!string.IsNullOrWhiteSpace(questionTextBox.Text)) { questionIs = true; }
            if (!string.IsNullOrWhiteSpace(answerOne.Text) && !string.IsNullOrWhiteSpace(answerTwo.Text) && !string.IsNullOrWhiteSpace(answerThree.Text) && !string.IsNullOrWhiteSpace(answerFour.Text)) { answersAre = true; }
            if(firstRadio.IsChecked == true || secondRadio.IsChecked == true || thirdRadio.IsChecked == true || fourthRadio.IsChecked == true) { radiosAre = true; }

            if (questionIs == true && answersAre == true && radiosAre == true) { e.CanExecute = true; }
            else { e.CanExecute = false; }
        }
    }
}
