using System;

namespace BlackJackCountingCards
{
    class MainClass
    {
       

        public static void Main(string[] args)
        {


            //Creating Deck of Cards object
            DeckOfCards myDeck = new DeckOfCards();
            
            // Outputing List of Cards in Deck
            foreach (var item in myDeck.GetSuitOfCards(myDeck.PackClubs))
            {
                Console.WriteLine("Card Name is:{0} ", item.getCardName());
                Console.WriteLine("Card Value is:{0} ", item.CardValue);
                Console.WriteLine("Card type is:{0} ", item.TheCardType);
                Console.WriteLine("Card type is:{0} ", item.CardRank);
                Console.WriteLine("Out put of cards {0} \n", item.TheCardType);
            }


        }
    }
}
