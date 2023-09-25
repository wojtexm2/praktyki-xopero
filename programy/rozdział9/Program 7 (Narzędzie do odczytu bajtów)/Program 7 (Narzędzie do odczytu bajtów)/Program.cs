﻿using System.Text;

namespace Program_7__Narzędzie_do_odczytu_bajtów_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("Sposób użycia: hexdumper plik-do-wyświetlenia");
                System.Environment.Exit(1);
            }
            if (!File.Exists(args[0]))
            {
                Console.Error.WriteLine("Plik nie istnieje: {0}", args[0]);
            }
            using (Stream input = File.OpenRead(args[0]))
            {
                int position = 0;
                byte[] buffer = new byte[16];
                while (position < input.Length)
                {
                    int charactersRead = input.Read(buffer, 0, buffer.Length);
                    if (charactersRead > 0)
                    {
                        Console.Write("{0}: ", String.Format("{0:x4}", position));
                        position += charactersRead;
                        for (int i = 0; i < 16; i++)
                        {
                            if (i < charactersRead)
                            {
                                string hex = String.Format("{0:x2}", (byte)buffer[i]);
                                Console.Write(hex + " ");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                            if (i == 7) Console.Write("-- ");
                            if (buffer[i] < 32 || buffer[i] > 250)
                            {
                                buffer[i] = (byte)'.';
                            }
                            string bufferContents = Encoding.UTF8.GetString(buffer);
                            Console.WriteLine(" " + bufferContents.Substring(0, charactersRead));
                        }
                    }
                }
            }
        }
    }
}