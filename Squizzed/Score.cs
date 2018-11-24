using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squizzed
{
    public class Score
    {
        private int Points;

        public Score()
        {
            Points = 0;
        }

        public int GetScore()
        {
            return Points;
        }
        public void SetScore(int Points)
        {
            this.Points = Points;
        }

        public void GivePoint()
        {
            Points++;
        }
        public void TakePoint()
        {
            if (Points > 0)
            {
                Points--;
            }
        }
        public void ZeroPoints()
        {
            Points = 0;
        }
    }
}
