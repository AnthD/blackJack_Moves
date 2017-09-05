using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class PackCardsHeart : IPackCards
    {
        Card[] PackHearts = new Card[13];

        public PackCardsHeart()
        {
            SetCardPack();
        }


        public void SetCardPack()
        {
            
           
            /*================ Card of Hearts =============================*/

            for (int t = 0; t < PackHearts.Length ; t++)
            {
                // Console.WriteLine("entered for loop {0}", i);

                int cardValueStart = (t + 2);
                switch (t)
                {
                    case 9:
                        Card jackHeartsCard = new Card(new SuitesHearts());

                        jackHeartsCard.CardValue = 10;
                        jackHeartsCard.TheCardType = Card.CardType.Jack;
                        jackHeartsCard.CardRank = (int)Card.CardType.Jack;
                        // Console.WriteLine("entered for made jack{0}", jackHeartsCard.TheCardType);
                        this.PackHearts[t] = jackHeartsCard;
                        // cardPackCounter++;
                        break;
                    case 10:
                        Card queenHeartsCard = new Card(new SuitesHearts());
                        queenHeartsCard.CardValue = 10;
                        queenHeartsCard.TheCardType = Card.CardType.Queen;
                        queenHeartsCard.CardRank = (int)Card.CardType.Queen;
                        // Console.WriteLine("entered for made jack{0}", queenHeartsCard.TheCardType);
                        this.PackHearts[t] = queenHeartsCard;

                        break;
                    case 11:
                        Card kingHeartsCard = new Card(new SuitesHearts());
                        kingHeartsCard.CardValue = 10;
                        kingHeartsCard.TheCardType = Card.CardType.King;
                        kingHeartsCard.CardRank = (int)Card.CardType.King;
                        // Console.WriteLine("entered for made jack{0}", kingHeartsCard.TheCardType);
                        this.PackHearts[t] = kingHeartsCard;

                        break;
                    case 12:
                        Card aceHeartsCard = new Card(new SuitesHearts());
                        aceHeartsCard.CardValue = 11;
                        aceHeartsCard.TheCardType = Card.CardType.Ace;
                        aceHeartsCard.CardRank = (int)Card.CardType.Ace;
                        // Console.WriteLine("entered for made jack{0}", aceHeartsCard.TheCardType);
                        this.PackHearts[t] = aceHeartsCard;
                        break;

                    default:
                        Card heartsCard = new Card(new SuitesHearts());
                        heartsCard.CardValue = cardValueStart;
                        heartsCard.CardRank = (int)Card.CardType.Regurlar;
                        //Console.WriteLine("entered for made jack{0}", heartsCard.TheCardType);
                        this.PackHearts[t] = heartsCard;
                        break;
                }
            }

        }

        public Card[] GetCardPack()
        {

            return PackHearts;
        }
    }
}
