using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class PackCardsDiamonds: IPackCards
    {

        Card[] PackDiamonds = new Card[13];

        public PackCardsDiamonds()
        {
            SetCardPack();
        }

        public void SetCardPack()
        {


            /*================ Card of Hearts =============================*/

            for (int t = 0; t < PackDiamonds.Length; t++)
            {
                // Console.WriteLine("entered for loop {0}", i);

                int cardValueStart = (t + 2);
                switch (t)
                {
                    case 9:
                        Card jackDiamondCard = new Card(new SuitesDiamond());

                        jackDiamondCard.CardValue = 10;
                        jackDiamondCard.TheCardType = Card.CardType.Jack;
                        jackDiamondCard.CardRank = (int)Card.CardType.Jack;
                        // Console.WriteLine("entered for made jack{0}", jackHeartsCard.TheCardType);
                        this.PackDiamonds[t] = jackDiamondCard;
                        // cardPackCounter++;
                        break;
                    case 10:
                        Card queenDiamondCard = new Card(new SuitesDiamond());
                        queenDiamondCard.CardValue = 10;
                        queenDiamondCard.TheCardType = Card.CardType.Queen;
                        queenDiamondCard.CardRank = (int)Card.CardType.Queen;
                        // Console.WriteLine("entered for made jack{0}", queenHeartsCard.TheCardType);
                        this.PackDiamonds[t] = queenDiamondCard;

                        break;
                    case 11:
                        Card kingDiamondsCard = new Card(new SuitesDiamond());
                        kingDiamondsCard.CardValue = 10;
                        kingDiamondsCard.TheCardType = Card.CardType.King;
                        kingDiamondsCard.CardRank = (int)Card.CardType.King;
                        // Console.WriteLine("entered for made jack{0}", kingHeartsCard.TheCardType);
                        this.PackDiamonds[t] = kingDiamondsCard;
                        break;
                    case 12:
                        Card aceDiamondCard = new Card(new SuitesDiamond());
                        aceDiamondCard.CardValue = 11;
                        aceDiamondCard.TheCardType = Card.CardType.Ace;
                        aceDiamondCard.CardRank = (int)Card.CardType.Ace;
                        // Console.WriteLine("entered for made jack{0}", aceHeartsCard.TheCardType);
                        this.PackDiamonds[t] = aceDiamondCard;
                        break;

                    default:
                        Card DiamondCard = new Card(new SuitesDiamond());
                        DiamondCard.CardValue = cardValueStart;
                        DiamondCard.CardRank = (int)Card.CardType.Regurlar;
                        //Console.WriteLine("entered for made jack{0}", heartsCard.TheCardType);
                        this.PackDiamonds[t] = DiamondCard;
                        break;
                }
            }

        }

        public Card[] GetCardPack()
        {
            return PackDiamonds;

        }
    }
}
