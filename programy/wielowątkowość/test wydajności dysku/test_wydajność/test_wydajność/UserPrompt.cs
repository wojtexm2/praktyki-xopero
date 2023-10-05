using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_wydajność
{
    public class UserPrompt
    {
        public static string PromptForPath()
        {
            /*
            へ？読んだの？
            スマホを使いたかな。。。
            誰でもスマホを使うのは出来ますよ！簡単すぎるね
            */
            string path;
            Console.WriteLine("Wybierz ścieżkę do folderu");
            while (true)
            {
                path = Console.ReadLine();
                if (!Directory.Exists(path)) Console.WriteLine("Podaj właściwą ścieżkę do folderu!");
                else break;
            }
            return path;
        }
        public static int PromptForThreads()
        {
            int threads;

            Console.WriteLine("Podaj ilość wątków");
            while (true)
            {
                string count = Console.ReadLine();
                if (!int.TryParse(count, out threads)) Console.WriteLine("Podaj właściwą liczbę!");
                else if (threads <= 1) Console.WriteLine("Ilość wątków musi być większa od 1!");
                else break;
            }

            return threads;
        }
        public static double PromptForSize()
        {
            double size;

            Console.WriteLine("Podaj rozmiar danych testowych w megabajtach");
            while (true)
            {
                string sizeString = Console.ReadLine();
                if (!double.TryParse(sizeString, out size)) Console.WriteLine("Podaj właściwą liczbę!");
                else if (size < 1) Console.WriteLine("Ilość danych musi być większa od 0!");
                else break;
            }
            return size;
        }
    }
}
