using System;

namespace BlackJackCountingCards
{
    class MainClass
    {
       

        public static void Main(string[] args)
        {

            PackOfCards myCards = new PackOfCards();
            //  Card[] Cardpack = new Card[10];
            //Console.WriteLine("Hello World! \n");
            Console.WriteLine("Card name is: {0}, CardType is : {1}", myCards.getCardPack()[51].getCardName(), myCards.getCardPack()[51].TheCardType);



            //foreach (var item in myCards.getCardPack())
            //{
            //    Console.WriteLine("Card Name is:{0} ", item.getCardName());
            //    Console.WriteLine("Card type is:{0} ", item.TheCardType);
            //    Console.WriteLine("Card type is:{0} ", item.CardRank);
            //    Console.WriteLine("Out put of cards {0} \n", item.TheCardType);
            //}






        }
    }
}
