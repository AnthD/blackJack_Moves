using System;
namespace BlackJackCountingCards
{
    public class SuitesClubs:ISuites
    {
       private string name;
        private string pic;
        
        public string Name 
        { 
            get
            {
                return this.name = "Clubs";
            }

        }
        public string Pic 
        { 
            
            get{
                return this.pic = "This is a club";
            }
            set
            {
                this.pic = value;
            } 
        }
    }
}
