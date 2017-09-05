using System;
namespace BlackJackCountingCards
{
    public class SuitesSpades: ISuites
    {
		private string name;
		private string pic;

		public string Name
		{
			get
			{
				return this.name = "Spades";
			}

		}
		public string Pic
		{
			get
			{
				return this.pic = "This is a Spades";
			}
			set
			{
				this.pic = value;
			}
		}
    }
}
