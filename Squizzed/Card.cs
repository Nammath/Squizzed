using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squizzed
{
    public class Card
    {
        private string CardQuestion;
        private List<Answer> CardAnswers;
        private string CardCategory;

        public Card(string CardQuestion, List<Answer> CardAnswers)
        {
            this.CardQuestion = CardQuestion;
            this.CardAnswers = CardAnswers;
        }

        public string GetQuestion()
        {
            return CardQuestion;
        }
        public void SetQuestion(string CardQuestion)
        {
            this.CardQuestion = CardQuestion;
        }
        public Answer GetAnswer(int AnswerIndex)
        {
            return CardAnswers[AnswerIndex];
        }
        public void SetAnswer(string AnswerContents, bool AnswerResult, int AnswerIndex)
        {
            CardAnswers[AnswerIndex].SetContents(AnswerContents);
            CardAnswers[AnswerIndex].SetResult(AnswerResult);
        }
        public List<Answer> GetAnswers()
        {
            return CardAnswers;
        }
        public void SetAnswers(List<Answer> CardAnswers)
        {
            this.CardAnswers = CardAnswers;
        }
        public string GetCategory()
        {
            return CardCategory;
        }
        public void SetCategory(string CardCategory)
        {
            this.CardCategory = CardCategory;
        }
    }
}
