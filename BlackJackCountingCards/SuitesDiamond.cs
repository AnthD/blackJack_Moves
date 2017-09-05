using System;
namespace BlackJackCountingCards
{
    public class SuitesDiamond:ISuites
    {
			//private string name;
			private string pic;

			public string Name
			{
				get
				{
					return  "Diamonds";
				}
            
			}
			public string Pic
			{
				get
				{
					return this.pic = "This is a Diamonds";
				}
				set
				{
					this.pic = value;
				}
			}
		
    }
}
