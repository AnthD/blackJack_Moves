using System;
namespace BlackJackCountingCards
{
    public interface IPackCards
    {
        void SetCardPack();
        Card[] GetCardPack();
    }
}
