using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        private List<(string, bool)> deck;

        public Deck()
        {
            deck = new List<(string, bool)>();
            InitializeDeck();
        }
        private void InitializeDeck()
        {
            deck.Add(("2IR02.png", false));
            deck.Add(("3IR03.png", false));
            deck.Add(("4IR04.png", false));
            deck.Add(("5IR05.png", false));
            deck.Add(("6IR06.png", false));
            deck.Add(("7IR07.png", false));
            deck.Add(("8IR08.png", false));
            deck.Add(("9IR09.png", false));
            deck.Add(("10IR10.png", false));
            deck.Add(("AIRA.png", false));
            deck.Add(("JIR10.png", false));
            deck.Add(("QIR10.png", false));
            deck.Add(("KIR10.png", false));
            deck.Add(("2T02.png", false));
            deck.Add(("3T03.png", false));
            deck.Add(("4T04.png", false));
            deck.Add(("5T05.png", false));
            deck.Add(("6T06.png", false));
            deck.Add(("7T07.png", false));
            deck.Add(("8T08.png", false));
            deck.Add(("9T09.png", false));
            deck.Add(("10T10.png", false));
            deck.Add(("ATA.png", false));
            deck.Add(("JT10.png", false));
            deck.Add(("QT10.png", false));
            deck.Add(("KT10.png", false));
            deck.Add(("2R02.png", false));
            deck.Add(("3R03.png", false));
            deck.Add(("4R04.png", false));
            deck.Add(("5R05.png", false));
            deck.Add(("6R06.png", false));
            deck.Add(("7R07.png", false));
            deck.Add(("8R08.png", false));
            deck.Add(("9R09.png", false));
            deck.Add(("10R10.png", false));
            deck.Add(("ARA.png", false));
            deck.Add(("JR10.png", false));
            deck.Add(("QR10.png", false));
            deck.Add(("KR10.png", false));
            deck.Add(("2IN02.png", false));
            deck.Add(("3IN03.png", false));
            deck.Add(("4IN04.png", false));
            deck.Add(("5IN05.png", false));
            deck.Add(("6IN06.png", false));
            deck.Add(("7IN07.png", false));
            deck.Add(("8IN08.png", false));
            deck.Add(("9IN09.png", false));
            deck.Add(("10IN10.png", false));
            deck.Add(("AINA.png", false));
            deck.Add(("JIN10.png", false));
            deck.Add(("QIN10.png", false));
            deck.Add(("KIN10.png", false));
            deck.Add(("back.png", false));
        }
        public string DrawCard()
        {
            Random random = new Random();
            int index = random.Next(deck.Count);
            while (deck[index].Item2)
            {
                index = random.Next(deck.Count);
            }
            deck[index] = (deck[index].Item1, true);
            return deck[index].Item1;
        }
        public void ResetDeck()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                deck[i] = (deck[i].Item1, false);
            }
        }
        public int Count
        {
            get
            {
                return deck.Count;
            }
        }
    }
}
