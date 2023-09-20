namespace Program_2__Lista_kaczek_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(){ Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck(){ Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck(){ Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck(){ Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck(){ Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck(){ Kind = KindOfDuck.Decoy, Size = 13 },
            };
            DuckComparerBySize sizeComparer = new DuckComparerBySize();
            DuckComparerByKind kindComparer = new DuckComparerByKind();
            DuckComparer comparer = new DuckComparer();

            PrintDucks(ducks);
            ducks.Sort(sizeComparer);
            PrintDucks(ducks);
            ducks.Sort(kindComparer);
            PrintDucks(ducks);
            comparer.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);
            Console.ReadKey();
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck);
            }
            Console.WriteLine("Koniec kaczek!");
        }
    }
}