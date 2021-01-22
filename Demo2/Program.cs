using System;
using System.Linq;
namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var puntenReeks = new[]
            {
                new { X=0,Y=1},
                new { X=1,Y=1},
                new { X=2, Y=-1}
            };
            int aantalMetXGroterDan0 =  puntenReeks.Where(p => p.X >= 1).Count();
            int somVanYwaarden = puntenReeks.Sum(p => p.Y);
            int somVanYwaarden2 =
                    (from p in puntenReeks
                     select p).Sum(p => p.Y);
        }
    }
}
