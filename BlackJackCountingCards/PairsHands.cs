using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class PairsHands : IHandState
    {
        Card myCard1;
        Card myCard2;
        Card dealerCard;
        public PairsHands(Card Card1, Card Card2, Card DealerCard)
        {
            this.myCard1 = Card1;
            this.myCard2 = Card2;
            this.dealerCard = DealerCard;

        }
        public void doAction(CardContext context)
        {
            context.setCardState(this);
            Console.WriteLine("This the Pairs hands");
            Console.WriteLine("My first Card is:{0} and my Second card is:{1}", this.myCard1.getCardName(), this.myCard2.getCardName());
            Console.WriteLine("My Dealer Card is:{0}", this.dealerCard.getCardName());
            
        }
    }
}
