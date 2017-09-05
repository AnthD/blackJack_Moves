using System;
using System.Collections.Generic;
namespace BlackJackCountingCards
{
    public class DeckOfCards
    {

       private List<Card> fullDeck = new List<Card>();
        private IPackCards packDiamonds = new PackCardsDiamonds();
        private IPackCards packHearts = new PackCardsHeart();
        private IPackCards packSpades = new PackCardsSpades();
        private IPackCards packClubs = new PackCardsClubs();
        private IPackCards packNoSuite = new PackCardsNoSuit();
        

        public IPackCards PackDiamonds
        {
            get
            {
                return packDiamonds;
            }
        }

        public IPackCards PackHearts
        {
            get
            {
                return packHearts;
            }

        }

        public IPackCards PackSpades
        {
            get
            {
                return packSpades;
            }

        }

        public IPackCards PackClubs
        {
            get
            {
                return packClubs;
            }
        }

        public IPackCards PackNoSuite
        {
            get
            {
                return packNoSuite;
            }
        }

        public DeckOfCards()
        {


            // Console.WriteLine("card name is:{0} ", myCard.getCardName());

            foreach (var item in packClubs.GetCardPack())
            {
                fullDeck.Add(item);
                //Console.WriteLine("card name is:{0} \n ", item.getCardName());
            }

            foreach (var item in packHearts.GetCardPack())
            {
                fullDeck.Add(item);
                //Console.WriteLine("card name is:{0} \n ", item.getCardName());
            }

            foreach (var item in packSpades.GetCardPack())
            {
                fullDeck.Add(item);
                //Console.WriteLine("card name is:{0} \n ", item.getCardName());
            }

            foreach (var item in packDiamonds.GetCardPack())
            {
                fullDeck.Add(item);
                // Console.WriteLine("card name is:{0} \n ", item.getCardName());
            }

        }



        public List<Card> GetSuitOfCards(IPackCards suitOfCards)
        {
            List<Card> aSuitofCards = new List<Card>();
            foreach (var item in suitOfCards.GetCardPack())
            {
                aSuitofCards.Add(item);
                //Console.WriteLine("card name is:{0} \n ", item.getCardName());
            }

            return aSuitofCards;
        }

        public List<Card> GetFullDeck()
		{
			return fullDeck;
		}


    }
}