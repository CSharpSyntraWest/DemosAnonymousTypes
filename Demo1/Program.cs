using System;
using System.Diagnostics.CodeAnalysis;

namespace Demo1
{
    class Hond :IEquatable<Hond> //Named Type
    { 
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public bool Equals([AllowNull] Hond other)
        {
            return Naam == other.Naam && Leeftijd == other.Leeftijd;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            //Aanmaken van een anonymous type:
            var hond1 = new { Naam = "Bobby", Leeftijd = 2 };
            var hond2 = new { Naam = "Bobby", Leeftijd = 2 };
            Console.WriteLine(hond1.Naam + " Leeftijd = " + hond1.Leeftijd);
            Console.WriteLine("Hond1 is gelijk aan hond2? " + hond1.Equals(hond2));

            Hond hond3 = new Hond { Naam = "Bobby", Leeftijd = 2 };
            Hond hond4 = new Hond { Naam = "Bobby", Leeftijd = 2 };

            Console.WriteLine(hond3.Naam + " Leeftijd = " + hond3.Leeftijd);
            Console.WriteLine("Hond3 is gelijk aan hond4? " + hond3.Equals(hond4));
        }
    }
}
