using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class PackCardsNoSuit : IPackCards
    {

        Card[] PackOfCards = new Card[13];

        public PackCardsNoSuit()
        {
            SetCardPack();
        }

        public void SetCardPack()
        {

            /*================ CARD  WITH NO SUIT =============================*/

            for (int t = 0; t < PackOfCards.Length; t++)
            {
                // Console.WriteLine("entered for loop {0}", i);

                int cardValueStart = (t + 2);
                switch (t)
                {
                    case 9:
                        Card jackCard = new Card();

                        jackCard.CardValue = 10;
                        jackCard.TheCardType = Card.CardType.Jack;
                        jackCard.CardRank = (int)Card.CardType.Jack;
                        // Console.WriteLine("entered for made jack{0}", jackHeartsCard.TheCardType);
                        this.PackOfCards[t] = jackCard;

                        break;
                    case 10:
                        Card queenCard = new Card();
                        queenCard.CardValue = 10;
                        queenCard.TheCardType = Card.CardType.Queen;
                        queenCard.CardRank = (int)Card.CardType.Queen;
                        // Console.WriteLine("entered for made jack{0}", queenHeartsCard.TheCardType);
                        this.PackOfCards[t] = queenCard;
                        break;
                    case 11:
                        Card kingCard = new Card();
                        kingCard.CardValue = 10;
                        kingCard.TheCardType = Card.CardType.King;
                        kingCard.CardRank = (int)Card.CardType.King;
                        // Console.WriteLine("entered for made jack{0}", kingHeartsCard.TheCardType);
                        this.PackOfCards[t] = kingCard;

                        break;
                    case 12:
                        Card aceHeartsCard = new Card();
                        aceHeartsCard.CardValue = 11;
                        aceHeartsCard.TheCardType = Card.CardType.Ace;
                        aceHeartsCard.CardRank = (int)Card.CardType.Ace;
                        // Console.WriteLine("entered for made jack{0}", aceHeartsCard.TheCardType);
                        this.PackOfCards[t] = aceHeartsCard;
                        break;

                    default:
                        Card heartsCard = new Card();
                        heartsCard.CardValue = cardValueStart;
                        heartsCard.CardRank = (int)Card.CardType.Regurlar;
                        //Console.WriteLine("entered for made jack{0}", heartsCard.TheCardType);
                        this.PackOfCards[t] = heartsCard;
                        break;
                }
            }

        }

        /*================ CARD RETURN PACK =============================*/
        public Card[] GetCardPack()
        {

            return PackOfCards;
        }
    }
}
