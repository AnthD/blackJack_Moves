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
                    //case '0':
                    //    card1 = mycard[0];
                    //    Console.WriteLine("First card is: {0}", card1.getCardName());
                    //    Console.WriteLine("choose second card:");
                    //    mykey = Console.ReadLine();
                    //    userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                    //    //----------------------------------------

                    //    //Console.WriteLine("you pressed Q");
                    //    break;

                    case '2':
                        card1 = mycard[0];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());

                        //Console.WriteLine("you pressed W");
                        break;

                    case '3':
                        card1 = mycard[1];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '4':
                        card1 = mycard[2];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '5':
                        card1 = mycard[3];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '6':
                        card1 = mycard[4];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '7':
                        card1 = mycard[5];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '8':
                        card1 = mycard[6];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '9':
                        card1 = mycard[7];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 't':
                        card1 = mycard[8];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'j':
                        card1 = mycard[9];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'q':
                        card1 = mycard[10];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'k':
                        card1 = mycard[11];
                        Console.WriteLine("First card is: {0}", card1.getCardName());
                        Console.WriteLine("choose second card:");
                        mykey = Console.ReadLine();
                        userAct2 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'a':
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
                    //case '0':
                    //    card2 = mycard[0];
                    //    Console.WriteLine("Second card is: {0}", card2.getCardName());
                    //    Console.WriteLine("choose dealer card:");
                    //    mykey = Console.ReadLine();
                    //    userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                    //    //----------------------------------------

                    //    //Console.WriteLine("you pressed Q");
                    //    break;

                    //case '1':
                    //    card2 = mycard[0];
                    //    Console.WriteLine("Second card is: {0}", card2.getCardName());
                    //    Console.WriteLine("choose dealer card:");
                    //    mykey = Console.ReadLine();
                    //    userAct3 = Convert.ToChar(mykey.ToLower().Trim());

                    //    //Console.WriteLine("you pressed W");
                    //    break;

                    case '2':
                        card2 = mycard[0];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;

                    case '3':
                        card2 = mycard[1];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '4':
                        card2 = mycard[2];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '5':
                        card2 = mycard[3];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '6':
                        card2 = mycard[4];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '7':
                        card2 = mycard[5];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '8':
                        card2 = mycard[6];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '9':
                        card2 = mycard[7];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 't':
                        card2 = mycard[8];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'j':
                        card2 = mycard[9];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'q':
                        card2 = mycard[10];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'k':
                        card2 = mycard[11];
                        Console.WriteLine("Second card is: {0}", card2.getCardName());
                        Console.WriteLine("choose dealer card:");
                        mykey = Console.ReadLine();
                        userAct3 = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'a':
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
                   
                    //case '0':
                    //    DealerCard = mycard[0];

                    //Console.WriteLine("Dealer card is: {0}", DealerCard.getCardName());
                    //Console.WriteLine("press x to exit and get your best choise of what to do");
                    //mykey = Console.ReadLine();
                    //userAct = Convert.ToChar(mykey.ToLower().Trim());
                    //----------------------------------------

                    //Console.WriteLine("you pressed Q");
                    //break;
                    case '2':
                        DealerCard = mycard[0];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '3':
                        DealerCard = mycard[1];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                    userAct = Convert.ToChar(mykey.ToLower().Trim());

                    //Console.WriteLine("you pressed W");
                    break;

                    case '4':
                        DealerCard = mycard[2];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                    //----------------------------------------
                    //Console.WriteLine("you pressed W");
                    break;

                    case '5':
                        DealerCard = mycard[3];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '6':
                        DealerCard = mycard[4];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '7':
                        DealerCard = mycard[5];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '8':
                        DealerCard = mycard[6];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case '9':
                        DealerCard = mycard[7];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 't':
                        DealerCard = mycard[8];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'j':
                        DealerCard = mycard[9];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'q':
                        DealerCard = mycard[10];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'k':
                        DealerCard = mycard[11];
                        Console.WriteLine("Deal card is: {0}", DealerCard.getCardName());
                        Console.WriteLine("press x to exit and get your best choise of what to do");
                        mykey = Console.ReadLine();
                        userAct = Convert.ToChar(mykey.ToLower().Trim());
                        //----------------------------------------
                        //Console.WriteLine("you pressed W");
                        break;
                    case 'a':
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
