using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_6__Idź_na_ryby____długie
{
    internal class Player
    {
        private String name;
        public String Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.cards = new Deck(new Card[] { });
            this.textBoxOnForm = textBoxOnForm;
            textBoxOnForm.Text += name + " przyłączył się do gry " + Environment.NewLine;
        }
        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value) howMany++;
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--) cards.Deal(card);
                }
            }
            return books;
        }
        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }
        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = cards.PullOutvalues(value);
            textBoxOnForm.Text += Name + " ma " + cardsIHave.Count + " " + Card.Plural(value, cardsIHave.Count) + Environment.NewLine;
            return cardsIHave;
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0) cards.Add(stock.Deal());
                Values randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
            }
        }
        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += Name + " pyta czy ktoś ma " + Card.Plural(value, 1) + Environment.NewLine;
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck cardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += cardsGiven.Count;
                    while (cardsGiven.Count > 0) cards.Add(cardsGiven.Deal());
                }
            }
            if (totalCardsGiven == 0)
            {
                textBoxOnForm.Text += Name + " pobrał kartęz kupki." + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card)
        {
            cards.Add(card);
        }
        public IEnumerable<string> GetCardNames()
        {
            return cards.GetCardNames();
        }
        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }
        public void SortHand()
        {
            cards.SortByValue();
        }
    }
}
