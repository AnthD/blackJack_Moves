using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class PackCardsSpades : IPackCards
    {

        Card[] PackSpades = new Card[13];

        public PackCardsSpades()
        {
            SetCardPack();
        }

        public void SetCardPack()
        {

            /*================ CARD SPADES =============================*/

            for (int t = 0; t < PackSpades.Length; t++)
            {
                // Console.WriteLine("entered for loop {0}", i);

                int cardValueStart = (t + 2);
                switch (t)
                {
                    case 9:
                        Card jackSpadesCard = new Card(new SuitesSpades());

                        jackSpadesCard.CardValue = 10;
                        jackSpadesCard.TheCardType = Card.CardType.Jack;
                        jackSpadesCard.CardRank = (int)Card.CardType.Jack;
                        // Console.WriteLine("entered for made jack{0}", jackHeartsCard.TheCardType);
                        this.PackSpades[t] = jackSpadesCard;

                        break;
                    case 10:
                        Card queenSpadesCard = new Card(new SuitesSpades());
                        queenSpadesCard.CardValue = 10;
                        queenSpadesCard.TheCardType = Card.CardType.Queen;
                        queenSpadesCard.CardRank = (int)Card.CardType.Queen;
                        // Console.WriteLine("entered for made jack{0}", queenHeartsCard.TheCardType);
                        this.PackSpades[t] = queenSpadesCard;
                        break;
                    case 11:
                        Card kingSpadesCard = new Card(new SuitesSpades());
                        kingSpadesCard.CardValue = 10;
                        kingSpadesCard.TheCardType = Card.CardType.King;
                        kingSpadesCard.CardRank = (int)Card.CardType.King;
                        // Console.WriteLine("entered for made jack{0}", kingHeartsCard.TheCardType);
                        this.PackSpades[t] = kingSpadesCard;

                        break;
                    case 12:
                        Card aceSpadesCard = new Card( new SuitesSpades());
                        aceSpadesCard.CardValue = 11;
                        aceSpadesCard.TheCardType = Card.CardType.Ace;
                        aceSpadesCard.CardRank = (int)Card.CardType.Ace;
                        // Console.WriteLine("entered for made jack{0}", aceHeartsCard.TheCardType);
                        this.PackSpades[t] = aceSpadesCard;
                        break;

                    default:
                        Card SpadesCard = new Card(new SuitesSpades());
                        SpadesCard.CardValue = cardValueStart;
                        SpadesCard.CardRank = (int)Card.CardType.Regurlar;
                        //Console.WriteLine("entered for made jack{0}", heartsCard.TheCardType);
                        this.PackSpades[t] = SpadesCard;
                        break;
                }
            }

        }

        /*================ CARD RETURN PACK =============================*/
        public Card[] GetCardPack()
        {

            return PackSpades;
        }

    }
}
