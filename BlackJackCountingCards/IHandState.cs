using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCountingCards
{
    interface IHandState
    {
        
        string doAction(CardContext context);
       //IHandActions handActions
       // {
       //     get;
       //     set;

       // }
    }
}
