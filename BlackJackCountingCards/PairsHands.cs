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
        IHandActions handActhion;
        public PairsHands(Card Card1, Card Card2, Card DealerCard)
        {
            this.myCard1 = Card1;
            this.myCard2 = Card2;
            this.dealerCard = DealerCard;

        }
        public void doAction(CardContext context)
        {
            context.setCardState(this);
            //Console.WriteLine("This the Pairs hands");
            //Console.WriteLine("My first Card is:{0} and my Second card is:{1}", this.myCard1.getCardName(), this.myCard2.getCardName());
            //Console.WriteLine("My Dealer Card is:{0}", this.dealerCard.getCardName());

            int myCardVules = myCard1.CardValue + myCard2.CardValue;
            int dealerCardValue = dealerCard.CardValue;
            //test for Ace

            if (myCard1.TheCardType == Card.CardType.Ace)
            {
                handActhion = new Split();
                Console.WriteLine("Your Pair Hands value is: {0}, Always SPlit on pare of  {1} {2}  ", myCardVules, myCard1.getCardName(), myCard2.getCardName());


            }
            else if ((myCard1.CardValue == 2  || myCard1.CardValue == 3) && dealerCardValue >=4 && dealerCardValue <=6  )
            {
                handActhion = new Split();
                Console.WriteLine("Your Pair Hands value is: {0}, Always SPlit on a pare of  {1} {2}  vs Dealer card of {3}", myCardVules, myCard1.getCardName(), myCard2.getCardName(), dealerCardValue);

            }
            else if ((myCard1.CardValue == 5) && dealerCardValue >= 2 && dealerCardValue <= 9 )
            {
                handActhion = new DoubleDown();
                Console.WriteLine("Your Pair Hands value is: {0}, Always Double Down on a pare of  {1} {2}  vs Dealer card of {3}", myCardVules, myCard1.getCardName(), myCard2.getCardName(), dealerCardValue);

            }
            else if ((myCard1.CardValue == 6) && dealerCardValue >= 2 && dealerCardValue <= 6)
            {
                handActhion = new Split();
                Console.WriteLine("Your Pair Hands value is: {0}, Always SPlit on a pare of  {1} {2}  vs Dealer card of {3}", myCardVules, myCard1.getCardName(), myCard2.getCardName(), dealerCardValue);

            }
            else if ((myCard1.CardValue == 7) && dealerCardValue >= 2 && dealerCardValue <= 7)
            {
                handActhion = new Split();
                Console.WriteLine("Your Pair Hands value is: {0}, Always SPlit on a pare of  {1} {2}  vs Dealer card of {3}", myCardVules, myCard1.getCardName(), myCard2.getCardName(), dealerCardValue);

            }
            else if (myCard1.CardValue == 8)
            {
                handActhion = new Split();
                Console.WriteLine("Your Pair Hands value is: {0}, Always SPlit on a pare of  {1} {2}  vs Dealer card of {3}", myCardVules, myCard1.getCardName(), myCard2.getCardName(), dealerCardValue);

            }
            else if ((myCard1.CardValue == 9) && (dealerCardValue >= 8 && dealerCardValue <= 9) && dealerCardValue >= 2 && dealerCardValue <= 6)
            {
                handActhion = new Split();
                Console.WriteLine("Your Pair Hands value is: {0}, Always SPlit on a pare of  {1} {2}  vs Dealer card of {3}", myCardVules, myCard1.getCardName(), myCard2.getCardName(), dealerCardValue);

            }
            else if ((myCard1.CardValue == 9) && (dealerCardValue >= 10 ||  dealerCardValue == 7))
            {
                handActhion = new Stick();
                Console.WriteLine("Your Pair Hands value is: {0}, Always Stick on a pare of  {1} {2}  vs Dealer card of {3}", myCardVules, myCard1.getCardName(), myCard2.getCardName(), dealerCardValue);

            }
            else if (myCard1.CardValue == 10)
            {
                handActhion = new Stick();
                Console.WriteLine("Your Pair Hands value is: {0}, Always Stick on a pare of  {1} {2}  vs Dealer card of {3}", myCardVules, myCard1.getCardName(), myCard2.getCardName(), dealerCardValue);

            }
            else
            {
                handActhion = new Hit();
                Console.WriteLine("Your Soft Hand value is: {0}, Always Hit on a pare of  {1} {2}  ", myCardVules, myCard1.getCardName(), myCard2.getCardName());

            }
        }
    }
}
