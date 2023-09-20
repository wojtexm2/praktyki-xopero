namespace Program_1__Test_interface_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Name = "Adam", Height = 74};
            tallGuy.TalkAboutYourself();
            tallGuy.Honk();
        }
    }
}