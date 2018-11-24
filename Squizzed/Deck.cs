using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squizzed
{
    public class Deck
    {
        public List<Card> ListOfCards;
        
        public Deck()
        {
            ListOfCards = new List<Card>();
        }

        public Card GetCard(int CardIndex)
        {
            return ListOfCards[CardIndex];
        }
        public void SetCard(int CardIndex, Card CardObject)
        {
            ListOfCards[CardIndex] = CardObject;
        }

        public void AddCard(Card CardObject)
        {
            ListOfCards.Add(CardObject);
        }
        public void DeleteCard(Card CardObject)
        {
            ListOfCards.Remove(CardObject);
        }
        public void DeleteCard(int CardIndex)
        {
            ListOfCards.RemoveAt(CardIndex);
        }
    }
}
