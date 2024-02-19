using System;

namespace FormulaFisica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double speed = 100.0; 
            double time = 5.0; 

            // Speed formula : V = D / T
             double velocity = speed / time;

            
            Console.WriteLine($"The speed is {velocity} m/s.");
        }
    }
}