using System;
namespace Upgift22
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("hur långt hoppade Elin i meter? (inga bokstäver)");
            string elinlängd = Console.ReadLine();
            int eLängd = int.Parse(elinlängd);
            Console.WriteLine("hur långt hoppade Alma? (inga bokstäver)");
            string Almalängd = Console.ReadLine();
            int Alängd = int.Parse(Almalängd);
            int X = eLängd - Alängd;
            Console.WriteLine("Elin hoppade" + " " + X + " " + "Meter längre än Alma");
        } 
    }   
}
