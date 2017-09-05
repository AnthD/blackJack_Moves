using System;
using System.Collections.Generic;
namespace BlackJackCountingCards
{
    public class PackOfCards
    {

        public List<Card> Cardpack = new List<Card>();

      /*  enum checkSuites
        {
            hearts,
            clubs,
            diamonds,
            spade,

        }
        */

            

        public  PackOfCards()
        {
           // Console.WriteLine("entered PACK OF CARDS");
            int standardSuitesCardsLength = 13;
            
            int cardPackCounter = 0;
            /*================ Card of Hearts =============================*/

            for (int t = 1; t <= standardSuitesCardsLength; t++)
            {
                // Console.WriteLine("entered for loop {0}", i);

                int cardValueStart = (t + 1);
                switch (t)
                {
                    case 10:
                        Card jackHeartsCard = new Card();
                        
                        jackHeartsCard.GetCardSuite(new SuitesHearts());
                        jackHeartsCard.CardValue = 10;
                        jackHeartsCard.TheCardType = Card.CardType.Jack;
                        jackHeartsCard.CardRank = (int)Card.CardType.Jack;
                       // Console.WriteLine("entered for made jack{0}", jackHeartsCard.TheCardType);
                        this.Cardpack.Add(jackHeartsCard);
                       // cardPackCounter++;
                        break;
                    case 11:
                        Card queenHeartsCard = new Card();
                        queenHeartsCard.GetCardSuite(new SuitesHearts());
                        queenHeartsCard.CardValue = 10;
                        queenHeartsCard.TheCardType = Card.CardType.Queen;
                        queenHeartsCard.CardRank = (int)Card.CardType.Queen;
                        // Console.WriteLine("entered for made jack{0}", queenHeartsCard.TheCardType);
                        this.Cardpack.Add(queenHeartsCard);
                        
                        break;
                    case 12:
                        Card kingHeartsCard = new Card();
                        kingHeartsCard.GetCardSuite(new SuitesHearts());
                        kingHeartsCard.CardValue = 10;
                        kingHeartsCard.TheCardType = Card.CardType.King;
                        kingHeartsCard.CardRank = (int)Card.CardType.King;
                        // Console.WriteLine("entered for made jack{0}", kingHeartsCard.TheCardType);
                        this.Cardpack.Add(kingHeartsCard);
            
                        break;
                    case 13:
                        Card aceHeartsCard = new Card();
                        aceHeartsCard.GetCardSuite(new SuitesHearts());
                        aceHeartsCard.CardValue = 11;
                        aceHeartsCard.TheCardType = Card.CardType.Ace;
                        aceHeartsCard.CardRank = (int)Card.CardType.Ace;
                        // Console.WriteLine("entered for made jack{0}", aceHeartsCard.TheCardType);
                        this.Cardpack.Add(aceHeartsCard);
                        cardPackCounter++;
                        break;

                    default:
                        Card heartsCard = new Card();
                        heartsCard.GetCardSuite(new SuitesHearts());
                        heartsCard.CardValue = cardValueStart;
                        heartsCard.CardRank = (int)Card.CardType.Regurlar;
                        //Console.WriteLine("entered for made jack{0}", heartsCard.TheCardType);
                        this.Cardpack.Add(heartsCard);
                
                        break;
                }
            }

            /*================ Card of Clubs =============================*/


            for (int t = 1; t <= standardSuitesCardsLength ; t++)
            {
                int cardValueStart = (t+1);

                switch (t)
                {
                    case 10:
                        Card jackClubsCard = new Card();
                        jackClubsCard.GetCardSuite(new SuitesClubs());
                        jackClubsCard.CardValue = 10;
                        jackClubsCard.TheCardType = Card.CardType.Jack;
                        jackClubsCard.CardRank = (int)Card.CardType.Jack;
                        this.Cardpack.Add(jackClubsCard);
                        
                        break;
                    case 11:
                        Card queenClubssCard = new Card();
                        queenClubssCard.GetCardSuite(new SuitesClubs());
                        queenClubssCard.CardValue = 10;
                        queenClubssCard.TheCardType = Card.CardType.Queen;
                        queenClubssCard.CardRank = (int)Card.CardType.Queen;
                        this.Cardpack.Add(queenClubssCard);
                       
                        break;
                    case 12:
                        Card kingClubsCard = new Card();
                        kingClubsCard.GetCardSuite(new SuitesClubs());
                        kingClubsCard.CardValue = 10;
                        kingClubsCard.TheCardType = Card.CardType.King;
                        kingClubsCard.CardRank = (int)Card.CardType.King;
                        this.Cardpack.Add(kingClubsCard);
                        
                        break;
                    case 13:
                        Card aceHeartsCard = new Card();
                        aceHeartsCard.GetCardSuite(new SuitesClubs());
                        aceHeartsCard.CardValue = 11;
                        aceHeartsCard.TheCardType = Card.CardType.Ace;
                        aceHeartsCard.CardRank = (int)Card.CardType.Ace;
                        this.Cardpack.Add(aceHeartsCard);
                        
                        break;

                    default:
                        Card clubsCard = new Card();
                        clubsCard.GetCardSuite(new SuitesClubs());
                        clubsCard.CardValue = cardValueStart;
                        clubsCard.CardRank = (int)Card.CardType.Regurlar;
                        // Console.WriteLine("entered for made Clubs{0}", clubsCard.TheCardType);
                        this.Cardpack.Add(clubsCard);
                       // cardValueStart++;
                        break;

                }

            }


            /*================ Card of Spades =============================*/


            for (int t = 1; t <= standardSuitesCardsLength; t++)
            {
                int cardValueStart = (t + 1);

                switch (t)
                {
                    case 10:
                        Card jackSpadesCard = new Card();
                        jackSpadesCard.GetCardSuite(new SuitesSpades());
                        jackSpadesCard.CardValue = 10;
                        jackSpadesCard.TheCardType = Card.CardType.Jack;
                        jackSpadesCard.CardRank = (int)Card.CardType.Jack;
                        this.Cardpack.Add(jackSpadesCard);
                       // cardPackCounter++;
                        break;
                    case 11:
                        Card queenSpadesCard = new Card();
                        queenSpadesCard.GetCardSuite(new SuitesClubs());
                        queenSpadesCard.CardValue = 10;
                        queenSpadesCard.TheCardType = Card.CardType.Queen;
                        queenSpadesCard.CardRank = (int)Card.CardType.Queen;
                        this.Cardpack.Add(queenSpadesCard);
                       // cardPackCounter++;
                        break;
                    case 12:
                        Card kingSpadesCard = new Card();
                        kingSpadesCard.GetCardSuite(new SuitesClubs());
                        kingSpadesCard.CardValue = 10;
                        kingSpadesCard.TheCardType = Card.CardType.King;
                        kingSpadesCard.CardRank = (int)Card.CardType.King;
                        this.Cardpack.Add(kingSpadesCard);
                        //cardPackCounter++;
                        break;
                    case 13:
                        Card aceSpadesCard = new Card();
                        aceSpadesCard.GetCardSuite(new SuitesSpades());
                        aceSpadesCard.CardValue = 11;
                        aceSpadesCard.TheCardType = Card.CardType.Ace;
                        aceSpadesCard.CardRank = (int)Card.CardType.Ace;
                        this.Cardpack.Add(aceSpadesCard);
                        //cardPackCounter++;
                        break;

                    default:
                        Card spadesCard = new Card();
                        spadesCard.GetCardSuite(new SuitesSpades());
                        spadesCard.CardValue = cardValueStart;
                        spadesCard.CardRank = (int)Card.CardType.Regurlar;
                        this.Cardpack.Add(spadesCard);
                       // cardPackCounter++;
                       // cardValueStart++;
                        break;

                }

            }

            /*================ Card of Diamonds =============================*/


            for (int t = 1; t <= standardSuitesCardsLength; t++)
            {
                int cardValueStart = (t + 1);

                switch (t)
                {
                    case 10:
                        Card jacksDiamondsCard = new Card();
                        jacksDiamondsCard.GetCardSuite(new SuitesDiamond());
                        jacksDiamondsCard.CardValue = 10;
                        jacksDiamondsCard.TheCardType = Card.CardType.Jack;
                        jacksDiamondsCard.CardRank = (int)Card.CardType.Jack;
                        this.Cardpack.Add(jacksDiamondsCard);
                        //cardPackCounter++;
                        break;
                    case 11:
                        Card queenDiamondsCard = new Card();
                        queenDiamondsCard.GetCardSuite(new SuitesDiamond());
                        queenDiamondsCard.CardValue = 10;
                        queenDiamondsCard.TheCardType = Card.CardType.Queen;
                        queenDiamondsCard.CardRank = (int)Card.CardType.Queen;
                        this.Cardpack.Add(queenDiamondsCard);
                        //cardPackCounter++;
                        break;
                    case 12:
                        Card kingDiamondsCard = new Card();
                        kingDiamondsCard.GetCardSuite(new SuitesDiamond());
                        kingDiamondsCard.CardValue = 10;
                        kingDiamondsCard.TheCardType = Card.CardType.King;
                        kingDiamondsCard.CardRank = (int)Card.CardType.King;
                        this.Cardpack.Add(kingDiamondsCard);
                        //Console.WriteLine("Count on Diamond King is: {0}", cardPackCounter);
                        //cardPackCounter++;
                        break;
                    case 13:
                        Card aceDiamondsCard = new Card();
                        aceDiamondsCard.GetCardSuite(new SuitesDiamond());
                        aceDiamondsCard.CardValue = 11;
                        aceDiamondsCard.TheCardType = Card.CardType.Ace;
                        aceDiamondsCard.CardRank = (int)Card.CardType.Ace;
                        this.Cardpack.Add(aceDiamondsCard);
                       // Console.WriteLine("Count on Diamond Ace is: {0}", cardPackCounter);
                        //cardPackCounter++;
                        break;

                    default:
                        Card DiamondCard = new Card();
                        DiamondCard.GetCardSuite(new SuitesDiamond());
                        DiamondCard.CardValue = cardValueStart;
                        DiamondCard.CardRank = (int)Card.CardType.Regurlar;
                        this.Cardpack.Add(DiamondCard);
                       // cardValueStart++;
                       // cardPackCounter++;
                        break;

                }

               

            }

            //foreach (var item in Cardpack)
            //{
            //    Console.WriteLine("Card Name is:{0} ", item.getCardName());
            //    Console.WriteLine("Card type is:{0} ", item.TheCardType);
            //    Console.WriteLine("Card type is:{0} ", item.CardRank);
            //    Console.WriteLine("Out put of cards {0} \n", item.TheCardType);
            //}



        }

        public List<Card> getCardPack()
		{
			return Cardpack;
		}
    }
}