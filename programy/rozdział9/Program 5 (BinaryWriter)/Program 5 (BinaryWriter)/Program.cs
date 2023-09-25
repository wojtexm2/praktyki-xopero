namespace Program_5__BinaryWriter_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intValue = 48769414;
            string stringValue = "Witaj!";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatValue = 491.695F;
            char charValue = 'E';

            using (FileStream output = File.Create("danebinarne.dat"))
                using (BinaryWriter writer = new BinaryWriter(output))
            {
                writer.Write(intValue);
                writer.Write(stringValue);
                writer.Write(byteArray);
                writer.Write(floatValue);
                writer.Write(charValue);
            }
            byte[] dataWritten = File.ReadAllBytes("danebinarne.dat");
            foreach (byte b in dataWritten) Console.Write("{0:x2} ", b);
            Console.Write(" - {0} bajtów", dataWritten.Length);
            Console.ReadKey();
        }
    }
}