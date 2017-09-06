using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class SoftHands : IHandState
    {
        Card myCard1;
        Card myCard2;
        Card dealerCard;
        IHandActions handActhion;
        public SoftHands(Card Card1, Card Card2, Card DealerCard)
        {
            this.myCard1 = Card1;
            this.myCard2 = Card2;
            this.dealerCard = DealerCard;

        }
        public void doAction(CardContext context)
        {
            context.setCardState(this);
            //Console.WriteLine("This Soft hands");
            //Console.WriteLine("My first Card is:{0} and my Second card is:{1}", this.myCard1.getCardName(), this.myCard2.getCardName());
            //Console.WriteLine("My Dealer Card is:{0}", this.dealerCard.getCardName());
            int myCardVules = myCard1.CardValue + myCard2.CardValue;
            int dealerCardValue = dealerCard.CardValue;
            //test for Ace
            var myAceCard = (myCard1.TheCardType == Card.CardType.Ace) ? myCard1 : myCard2;
            var myValueCard = (myCard1.TheCardType != Card.CardType.Ace) ? myCard1 : myCard2;

            if (myValueCard.CardValue >= 8 || myValueCard.CardValue <= 10)
            {
                handActhion = new Stick();
                Console.WriteLine("Your Soft Hand value is: {0}, Always Stick on a {1} and {2}  ", myCardVules, myAceCard.getCardName(), myValueCard.getCardName());

            } else if ((myValueCard.CardValue == 2) && dealerCardValue == 6)
            {
                handActhion = new DoubleDown();
                Console.WriteLine("Your Soft Hand value is: {0}, Always Double Down on a {1} and {2}  ", myCardVules, myAceCard.getCardName(), myValueCard.getCardName());

            }
            else if ((myValueCard.CardValue == 3) && dealerCardValue == 5 && dealerCardValue <= 6)
            {
                handActhion = new DoubleDown();
                Console.WriteLine("Your Soft Hand value is: {0}, Always Double Down on a {1} and {2}  ", myCardVules, myAceCard.getCardName(), myValueCard.getCardName());
            }
            else if ((myValueCard.CardValue == 4 || myValueCard.CardValue == 5) && dealerCardValue >= 4 && dealerCardValue <= 6)
            {
                handActhion = new DoubleDown();
                Console.WriteLine("Your Soft Hand value is: {0}, Always Double Down on a {1} and {2}  ", myCardVules, myAceCard.getCardName(), myValueCard.getCardName());

            }
            else if ((myValueCard.CardValue == 6 || myValueCard.CardValue == 7 ) && (dealerCardValue >= 3 && dealerCardValue <= 6))
            {
                handActhion = new DoubleDown();
                Console.WriteLine("Your Soft Hand value is: {0}, Always Double Down on a {1} and {2}  ", myCardVules, myAceCard.getCardName(), myValueCard.getCardName());

            }
            else if ((myValueCard.CardValue == 7) && dealerCardValue == 2 && dealerCardValue == 7 && dealerCardValue == 8)
            {
                handActhion = new Stick();
                Console.WriteLine("Your Soft Hand value is: {0}, Always Stick on a {1} and {2}  ", myCardVules, myAceCard.getCardName(), myValueCard.getCardName());

            }
            else
            {
                handActhion = new Hit();
                Console.WriteLine("Your Soft Hand value is: {0}, Always Hit on a {1} and {2}  ", myCardVules, myAceCard.getCardName(), myValueCard.getCardName());

            }

        }
    }
}
