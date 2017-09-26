using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    interface IHandActions
    {
        void doAction();
       
    }

    class Stick : IHandActions
    {
        public void doAction()
        {
            Console.WriteLine("You Should Stick");
        }
    }

    class Hit : IHandActions
    {
        public void doAction()
        {
            Console.WriteLine("You Should Hit ");
        }
    }

    class DoubleDown : IHandActions
    {
        public void doAction()
        {
            Console.WriteLine("You Should Double Down ");
        }
    }

    class Split : IHandActions
    {
        public void doAction()
        {
            Console.WriteLine("You Should Split the cards ");
        }
    }

   
}
