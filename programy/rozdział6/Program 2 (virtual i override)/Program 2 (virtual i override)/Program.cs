namespace Program_2__virtual_i_override_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);
            Console.ReadKey();
        }
    }
    class Jewels
    {
        public string sparkle()
        {
            return "Lśnimy i błyszczymy!";
        }
    }
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";
        public Jewels Open(string combination)
        {
            if (combination == safeCombination) return contents;
            else return null;
        }
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
    class Owner
    {
        private Jewels returnedContents;
        public void RecieveContents(Jewels safeContents)
        {
            returnedContents = safeContents;
            Console.WriteLine("Dzięuję za zwrócenie klejnotów! " + safeContents.sparkle());
        }
    }
    class Locksmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
        }
        private string writtenDownCombination = null;
        public void WriteDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }
        virtual public void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.RecieveContents(safeContents);
        }
    }
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("Kradnę zawartość sejfu! " + stolenJewels.sparkle());
        }
    }
}