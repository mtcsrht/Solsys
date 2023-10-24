using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Solsys
{
    class Program
    {

        static List<Bolygo> bolygok = new List<Bolygo>();
        static void Main()
        {
            using (var sr = new StreamReader(@"..\..\src\solsys.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    bolygok.Add(new Bolygo(sr.ReadLine()));
                }
            }

            Console.WriteLine($"3.1: {bolygok.Count} bolygó van a rendszerben");
            var f2 = bolygok.Average(b => b.HoldakSzama);
            Console.WriteLine($"3.2: A naprendszerben egy bolygónak átlagosan {f2:0.00} holdja van");
            var f3 = bolygok.OrderBy(b => b.TerfogatArany).Last();
            Console.WriteLine($"3.3 a legnagyobb bolygó a {f3.Nev}");

            Console.Write($"3.4 írd be a keresett bolygó nevét: ");
            string resp = Console.ReadLine();

            var f4 = bolygok.SingleOrDefault(b => b.Nev == resp);

            Console.WriteLine(f4 != null ? "Van ilyen bolygó a naprendszerben." : $"sajnos nincs ilyen nevű bolygó a naprendszerben");

            Console.Write("3.5 Írj be egy egész számot: ");
            resp = Console.ReadLine();

            var f5 = bolygok.Where(b => b.HoldakSzama > int.Parse(resp));
            Console.WriteLine($"A következő bolygóknak van {resp} nál/nél több holdja: ");
            foreach (var item in f5)
            {
                Console.Write($"{item.Nev} ");
            }
            Console.ReadLine();
        }
    }
}
