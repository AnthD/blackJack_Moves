using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class CardContext
    {
        private IHandState cardState;
        // Card[] contextCard;
        public CardContext()
        {
            cardState = null;
        }


        public void setCardState(IHandState cardState)
        {
            this.cardState = cardState;

        }

        public IHandState getCardState()
        {
            return this.cardState;
        } 




        //public void CompContextCard(Card myCard1, Card myCard2, Card dealerCard )
        //{
        //    if (myCard1 == null || myCard2 == null || dealerCard == null)
        //    {
        //        Console.WriteLine("Please set all cards");
        //        return;
        //    }


        //    if (myCard1.CardValue == myCard2.CardValue)
        //    {
        //        cardState = new PairsState();
        //    }
        //}
    }
}
