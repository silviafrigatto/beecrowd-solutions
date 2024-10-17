using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _1134.Enums;

namespace _1134.Models
{
    public class FuelCalculator
    {
        public int TotalAlcohol;
        public int TotalGasoline;
        public int TotalDiesel;
        
        public void FuelSold()
        {
            
            int input;
            
            do
            {
                input = int.Parse(Console.ReadLine()!);		
                switch (input)
                    {
                        case 1:
                            TotalAlcohol++; 
                            break;
                        case 2:
                            TotalGasoline++;
                            break;
                        case 3:
                            TotalDiesel++;
                            break;
                        case 4:
                            Console.WriteLine("MUITO OBRIGADO");
                            Console.WriteLine((FuelType)1 + ": " + TotalAlcohol);
                            Console.WriteLine((FuelType)2 + ": " + TotalGasoline);
                            Console.WriteLine((FuelType)3 + ": " + TotalDiesel);
                            break;
                        default:
                            FuelSold();
                            break;
                    }
            }
            while(input < 4);
        }
    }
}