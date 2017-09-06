using System;

namespace BlackJackCountingCards
{
    class MainClass
    {
        static char userAct;
        static char userAct2;
        static char userAct3;
        static string mykey;
         static Card card1;
         static Card card2;
         static Card DealerCard;


        public static void Main(string[] args)
        {


            //Creating Deck of Cards object
            DeckOfCards myDeck = new DeckOfCards();
            
           
            Card[] mycard = new Card[13];
            mycard = myDeck.GetSuitOfCards(myDeck.PackClubs).ToArray();
           

            
            // Outputing List of Cards in Deck
            foreach (var item in mycard)
            {
                Console.WriteLine("Card Name is:{0} ", item.getCardName());
                Console.WriteLine("Card Value is:{0} ", item.CardValue);
                Console.WriteLine("Card type is:{0} ", item.TheCardType);
                Console.WriteLine("Card type is:{0} ", item.CardRank);
                Console.WriteLine("Out put of cards {0} \n", item.TheCardType);
            }


            //Testing controls with user actions 
            Console.WriteLine(" press 0-12 to select a card starting card 2, and x to exit");
            Console.WriteLine("Choose first card: ");
            mykey = Console.ReadLine();
            userAct = Convert.ToChar(mykey.ToLower().Trim());

            do
            {
               
                switch (userAct)
                {
                    case '0':
                        card1 = mycard[0];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------

                        //Console.WriteLine("you pressed Q");
                        break;

                    case '1':
                        card1 = mycard[1];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());

                        //Console.WriteLine("you pressed W");
                        break;

                    case '2':
                        card1 = mycard[2];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;


                    case '3':
                        card1 = mycard[12];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                }


                switch (userAct2)
                {
                    case '0':
                        card2 = mycard[0];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------

                        //Console.WriteLine("you pressed Q");
                        break;

                    case '1':
                        card2 = mycard[1];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());

                        //Console.WriteLine("you pressed W");
                        break;

                    case '2':
                        card2 = mycard[2];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;

                    case '3':
                        card2 = mycard[12];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;

                }

                switch(userAct3)
                {
                   
                    case '0':
                        DealerCard = mycard[0];

                    Console.WriteLine("Dealer card is: {0}", DealerCard.getCardName());
                    Console.WriteLine("press x to exit and get your best choise of what to do");
                    mykey = Console.ReadLine();
                    userAct = Convert.ToChar(mykey.ToLower().Trim());
                    //----------------------------------------

                    //Console.WriteLine("you pressed Q");
                    break;

                    case '1':
                        DealerCard = mycard[0];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                    userAct = Convert.ToChar(mykey.ToLower().Trim());

                    //Console.WriteLine("you pressed W");
                    break;

                    case '2':
                        DealerCard = mycard[2];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                    //----------------------------------------
                    //Console.WriteLine("you pressed W");
                    break;

                    case '3':
                        DealerCard = mycard[12];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                }
               


            } while (userAct != 'x');


            SuggHandChoice mymoves = new SuggHandChoice();
            mymoves.CompContextCard(card1, card2, DealerCard);
        }
    }
}
