using Ispit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ispit.Model.Klase;

namespace Ispit_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Podaci po = new Podaci();

            var GrupirajPremaBanci = po.DajListuKlijenata.Where(
                k => k.Stanje >= 1000000.00).GroupBy(
                p => p.Banka,
                p => p.ImePrezime,
                (banka, milijunas) => new GrupiraniMilijunasi()
                {
                    Banka = banka,
                    Mlijunasi = milijunas
                }
                ).ToList();


            foreach (var rez in GrupirajPremaBanci)
            {
                Console.Write("Banka: " + rez.Banka + ": ");
                foreach (string s in rez.Mlijunasi)
                { Console.Write(s + "; "); }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            var IzvjestajMilijunasa = po.DajListuKlijenata.Where(p => p.Stanje >= 1000000.00);

            var qs_inner_join = from p in IzvjestajMilijunasa
                                join t in po.DajListuBanki
                                on p.Banka equals t.Simbol
                                where p.Stanje >= 1000000.00
                                orderby p.Banka
                                select new
                                {
                                    ImeprezimeMilijunasa = p.ImePrezime,
                                    Banka = t.Naziv
                                };
            foreach (var rez in qs_inner_join)
            {
                Console.WriteLine(rez.ImeprezimeMilijunasa + " je u " + rez.Banka);
            }

        }
    }
}
