﻿﻿using System;
namespace BlackJackCountingCards
{
    public class Card
    {
        private string cardName;
        private int cardValue;
        private CardType cardType;
        //private int cardRank;
       // string NoSuite = "Suiteless";
        ISuites cardSuite;

        public enum CardType
        {
            Regurlar,
            Jack,
            Queen,
            King,
            Ace
        }
        /*================ CARD CONSTRUCTOR  =============================*/
        public Card()
        {

           

        }


       public Card(ISuites mCardSuite)
        {
            this.cardSuite = mCardSuite;
        }



        /*================ Card CardType get set rank =============================*/
        public CardType TheCardType
        {
            get
            {
                return this.cardType;
            }
            set
            {
                this.cardType = value;
            }

        }

/*================ Card Value get set rank =============================*/
		public int CardValue
        {
            get
            {
                return cardValue;
            }

            set
            {
                this.cardValue = value;
            }
        }

/*================ Card Rank get set rank =============================*/

        public int CardRank
        {
            get;
            set;

        }


/*================ Method Sets the suit of the card =============================*/

        public void GetCardSuite( ISuites newSuite )
        {
            
            this.cardSuite = newSuite;
           
        }



/*================ Method gets the Card Name =============================*/

		public string getCardName()
        {
            CardType checkReg = CardType.Regurlar;
            if (checkReg != this.cardType) return royalCardName(this.cardType);
            return this.cardName = cardValue.ToString()+" "+ this.cardSuite.Name;
        }

        public string  royalCardName(CardType royalType)
        {

            return this.cardName = royalType.ToString() + " " + this.cardSuite.Name;
          
        }

    }
}
