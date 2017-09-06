using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    interface IHandState
    {
        
        void doAction(CardContext context);
       //IHandActions handActions
       // {
       //     get;
       //     set;

       // }
    }
}
