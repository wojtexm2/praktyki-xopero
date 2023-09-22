namespace Program_3__losowanie_i_sortowanie_kart_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>();
            CardComparer comparer = new CardComparer();

            Console.WriteLine("Pięć losowych kart:");
            for (int i = 0; i < 5; i++)
            {
                Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
                Console.WriteLine(card) ;
                cards.Add(card);
            }
            Console.WriteLine("\r\nPosegregowane karty:");
            cards.Sort(comparer);
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}