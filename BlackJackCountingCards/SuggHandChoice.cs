using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class SuggHandChoice
    {

        CardContext contextState = new CardContext();
        HardHands hardHands;
        SoftHands softHands;
        PairsHands pairsHands;
       
        public void CompContextCard(Card myCard1, Card myCard2, Card dealerCard)
        {
            if (myCard1 == null || myCard2 == null || dealerCard == null)
            {
                Console.WriteLine("Please set all cards");
                return;
            }

            //Narrow down possible actions 
            if ((myCard1.CardRank == myCard2.CardRank) && myCard1.CardValue == myCard2.CardValue)
            {
                this.pairsHands = new PairsHands(myCard1, myCard2, dealerCard);
                pairsHands.doAction(contextState);
                return;
            }
            else if (myCard1.TheCardType == Card.CardType.Ace || myCard2.TheCardType == Card.CardType.Ace)
            {
                softHands = new SoftHands(myCard1, myCard2, dealerCard);
                softHands.doAction(contextState);
                return;
            }
            else
            {
                hardHands = new HardHands(myCard1, myCard2, dealerCard);
                hardHands.doAction(contextState);

            }


        }

    }
}
