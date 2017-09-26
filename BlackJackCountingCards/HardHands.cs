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
        string actionMssg;
        IHandActions handActhion;
        public HardHands(Card Card1, Card Card2, Card DealerCard)
        {
            this.myCard1 = Card1;
            this.myCard2 = Card2;
            this.dealerCard = DealerCard;

        }
        public string doAction(CardContext context)
        {
            context.setCardState(this);
            //Console.WriteLine("This the Hard hands");
            //Console.WriteLine("My first Card is:{0} and my Second card is:{1}", this.myCard1.getCardName(), this.myCard2.getCardName());
            //Console.WriteLine("Dealer Card is:{0}", this.dealerCard.getCardName());
            int myCardVules = myCard1.CardValue + myCard2.CardValue;
            int dealerCardValue = dealerCard.CardValue;


            if (myCardVules >= 17)
            {
                handActhion = new Stick();
                //Console.WriteLine("Your Hand value is: {0}, Always Stick on a two card 17+", myCardVules);
               actionMssg = string.Format("Your Hand value is: {0}, Always Stick on a two card 17+", myCardVules);
            }
            else if ((myCardVules == 5) && myCardVules <= 8)
            {
                handActhion = new Hit();
                //Console.WriteLine("Your Hand value is: {0},Always Hit on cards a total card value of 5 - 8", myCardVules);

                actionMssg = string.Format("Your Hand value is: {0},Always Hit on cards a total card value of 5 - 8", myCardVules);
            }
            else if ((myCardVules == 13 && myCardVules <= 16) && dealerCardValue == 2 && dealerCardValue <= 6)
            {
                handActhion = new Stick();
                //Console.WriteLine("Your Hand value is: {0}, Always Stick when vs dealers faceup card {1},", myCardVules, dealerCardValue);
                actionMssg = string.Format("Your Hand value is: {0}, Always Stick when vs dealers faceup card {1},", myCardVules, dealerCardValue);
            }
            else if ((myCardVules == 13 && myCardVules <= 16) && dealerCardValue >= 7)
            {
                handActhion = new Hit();
               // Console.WriteLine("Your Hand value is: {0}, Always Hit when vs dealers faceup card {1},", myCardVules, dealerCardValue);
                actionMssg = string.Format("Your Hand value is: {0}, Always Stick when vs dealers faceup card {1},", myCardVules, dealerCardValue);
            }
            else if (((myCardVules == 12) && dealerCardValue == 2 && dealerCardValue <= 3) || ((myCardVules == 12) && dealerCardValue >= 7))
            {
                handActhion = new Hit();
                //Console.WriteLine("Your Hand value is: {0}, Always Hit when vs dealers faceup card {1},", myCardVules, dealerCardValue);
                actionMssg = string.Format("Your Hand value is: {0}, Always Hit when vs dealers faceup card {1},", myCardVules, dealerCardValue);
            }
            else if ((myCardVules == 12) && dealerCardValue == 4 && dealerCardValue <= 6)
            {
                handActhion = new Stick();
                //Console.WriteLine("Your Hand value is: {0}, Always Stick when vs dealers faceup card {1},", myCardVules, dealerCardValue);
                actionMssg = string.Format("Your Hand value is: {0}, Always Stick when vs dealers faceup card {1},", myCardVules, dealerCardValue);
            }
            else if ((myCardVules == 9) && dealerCardValue == 2 || dealerCardValue >= 7)
            {
                handActhion = new Hit();
                //Console.WriteLine("Your Hand value is: {0}, Always Hit when vs dealers faceup card {1},", myCardVules, dealerCardValue);
                actionMssg = string.Format("Your Hand value is: {0}, Always Hit when vs dealers faceup card {1},", myCardVules, dealerCardValue);
            }//---------Double Down Starts
            else if (((myCardVules == 9) && dealerCardValue == 3 && dealerCardValue <= 6) || ((myCardVules == 10)&& dealerCardValue >= 9) || ((myCardVules == 11) && dealerCardValue >= 10 ))
            {
                handActhion = new DoubleDown();
                //Console.WriteLine("Your Hand value is: {0}, Always Double Down when vs dealers faceup card {1},", myCardVules, dealerCardValue);
                actionMssg = string.Format("Your Hand value is: {0}, Always Double Down when vs dealers faceup card {1},", myCardVules, dealerCardValue);
            }

            return actionMssg;

        }






    }


}
