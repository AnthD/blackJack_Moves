using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    class PackCardsClubs:IPackCards
    {

        Card[] PackClubs = new Card[13];

        public PackCardsClubs()
        {
            SetCardPack();
        }

        public void SetCardPack()
        {

            /*================ CARD SPADES =============================*/

            for (int t = 0; t < PackClubs.Length; t++)
            {
                // Console.WriteLine("entered for loop {0}", i);

                int cardValueStart = (t + 2);
                switch (t)
                {
                    case 9:
                        Card jackClubsCard = new Card(new SuitesClubs());

                        jackClubsCard.CardValue = 10;
                        jackClubsCard.TheCardType = Card.CardType.Jack;
                        jackClubsCard.CardRank = (int)Card.CardType.Jack;
                        // Console.WriteLine("entered for made jack{0}", jackHeartsCard.TheCardType);
                        this.PackClubs[t] = jackClubsCard;

                        break;
                    case 10:
                        Card queenClubsCard = new Card(new SuitesClubs());
                        queenClubsCard.CardValue = 10;
                        queenClubsCard.TheCardType = Card.CardType.Queen;
                        queenClubsCard.CardRank = (int)Card.CardType.Queen;
                        // Console.WriteLine("entered for made jack{0}", queenHeartsCard.TheCardType);
                        this.PackClubs[t] = queenClubsCard;
                        break;
                    case 11:
                        Card kingClubsCard = new Card(new SuitesClubs());
                        kingClubsCard.CardValue = 10;
                        kingClubsCard.TheCardType = Card.CardType.King;
                        kingClubsCard.CardRank = (int)Card.CardType.King;
                        // Console.WriteLine("entered for made jack{0}", kingHeartsCard.TheCardType);
                        this.PackClubs[t] = kingClubsCard;

                        break;
                    case 12:
                        Card aceClubsCard = new Card(new SuitesClubs());
                        aceClubsCard.CardValue = 11;
                        aceClubsCard.TheCardType = Card.CardType.Ace;
                        aceClubsCard.CardRank = (int)Card.CardType.Ace;
                        // Console.WriteLine("entered for made jack{0}", aceHeartsCard.TheCardType);
                        this.PackClubs[t] = aceClubsCard;
                        break;

                    default:
                        Card clubsCard = new Card(new SuitesClubs());
                        clubsCard.CardValue = cardValueStart;
                        clubsCard.CardRank = (int)Card.CardType.Regurlar;
                        //Console.WriteLine("entered for made jack{0}", heartsCard.TheCardType);
                        this.PackClubs[t] = clubsCard;
                        break;
                }
            }

        }

        /*================ CARD RETURN PACK =============================*/
        public Card[] GetCardPack()
        {

            return PackClubs;
        }

    }
}
