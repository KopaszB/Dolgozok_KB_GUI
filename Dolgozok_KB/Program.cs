using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dolgozok_KB
{
    class Program
    {
        static List<Dolgozo> dolgozok = new List<Dolgozo>();

        static void Main(string[] args)
        {
            beolvasas();
            feladat01();
            feladat02();
            feladat03();
            feladat04();

            /*foreach (Dolgozo item in dolgozok)
            {
                Console.WriteLine(item.Nev);
            }*/

            Console.WriteLine("Program vége!");
            Console.ReadLine();
        }

        private static void feladat04()
        {
            Console.WriteLine($"4.feladat: Az asztalosműhely dolgozóinak száma:");
            foreach (var item in dolgozok.FindAll(a => a.Reszleg == "asztalosműhely"))
            {
                Console.WriteLine($"{item.Nev}");
            }
        }


        private static void feladat03()
        {
            foreach (var item in dolgozok.GroupBy(a => a.Reszleg).Select(b => new {Reszleg = b.Key, Letszam = b.Count() }))
            {


                Console.WriteLine($"3.feladat: {item.Reszleg} : {item.Letszam}");
            }
            
        }

        private static void feladat02()
        {
            /*
            int maxber = dolgozok[0].Ber;
            int j = 0;
            for (int i = 0; i < dolgozok.Count; i++)
            {
                if (dolgozok[i].Ber > maxber)
                {
                    maxber = dolgozok[i].Ber;
                    j = i;
                }
            }
            */
            Dolgozo max = dolgozok.Find(a => a.Ber == dolgozok.Max(b => b.Ber));
            Console.WriteLine($"2.feladat - A legtöbb bért kereső dolgozó: {max.Nev}");
        }

        private static void feladat01()
        {
            Console.WriteLine($"1.feladat - A dolgozók száma: {dolgozok.Count}");
        }

        private static void beolvasas()
        {
            using (StreamReader sr = new StreamReader("dolgozok.csv"))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] adatsor = sr.ReadLine().Replace('"',' ').Split(',');
                    Dolgozo dolgozo = new Dolgozo(adatsor[0].Trim(), adatsor[1].Trim(), adatsor[2].Trim(), int.Parse(adatsor[3].Trim()), int.Parse(adatsor[4].Trim()) );
                    dolgozok.Add(dolgozo);
                }
            }

        }
    }
}
