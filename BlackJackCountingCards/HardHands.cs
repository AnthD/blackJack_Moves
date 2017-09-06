using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class HardHands : IHandState
    {
        Card myCard1;
        Card myCard2;
        Card dealerCard;
        public HardHands(Card Card1, Card Card2, Card DealerCard)
        {
            this.myCard1 = Card1;
            this.myCard2 = Card2;
            this.dealerCard = DealerCard;

        }
        public void doAction(CardContext context)
        {
            context.setCardState(this);
            Console.WriteLine("This the Hard hands");
            Console.WriteLine("My first Card is:{0} and my Second card is:{1}", this.myCard1.getCardName(), this.myCard2.getCardName());
            Console.WriteLine("Dealer Card is:{0}", this.dealerCard.getCardName());
            int myCardVules = myCard1.CardValue + myCard2.CardValue;


            if (myCardVules >= 17)
            {
                Console.WriteLine("Always Stick on a two card 17+");
            }

           

        }




    }


}
