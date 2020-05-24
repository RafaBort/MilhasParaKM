using System;

namespace MilhasParaKM
{
    class Program
    {
        static void Main(string[] args)
        {
            string milhas;
     
            Console.WriteLine("Coloque uma medida em milhas...");
            milhas = Console.ReadLine();
            Console.WriteLine("Milhas em KM vale 1,609");

            Double KM1 = Convert.ToInt16(milhas);
            Double y = KM1;
            Double x = 1.609;

            Double multiplicacao = ( x * KM1); 

            Console.WriteLine(multiplicacao);

            









        }
    }
}
