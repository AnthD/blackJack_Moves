using System;
namespace BlackJackCountingCards
{
    public class SuitesHearts: ISuites
    {
		private string name;
		private string pic;

		public string Name
		{
			get
			{
				return this.name = "Hearts";
			}

		}
		public string Pic
		{
			get
			{
				return this.pic = "This is a Hearts";
			}
			set
			{
				this.pic = value;
			}
		}
    }
}
