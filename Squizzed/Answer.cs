using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squizzed
{
    public class Answer
    {
        private string AnswerContents;
        private bool AnswerResult;

        public Answer(string AnswerContents, bool AnswerResult)
        {
            this.AnswerContents = AnswerContents;
            this.AnswerResult = AnswerResult;
        }

        public string GetContents()
        {
            return AnswerContents;
        }
        public void SetContents(string AnswerContents)
        {
            this.AnswerContents = AnswerContents;
        }
        public bool GetResult()
        {
            return AnswerResult;
        }
        public void SetResult(bool AnswerResult)
        {
            this.AnswerResult = AnswerResult;
        }
    }
}
