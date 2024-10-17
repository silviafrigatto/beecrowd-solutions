<<<<<<< HEAD
﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        int numberOfLines = int.Parse(Console.ReadLine());

        if(numberOfLines < 1 && numberOfLines > 1000)
        {
            for(int i = 1; i <= numberOfLines; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }  
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
=======
﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();
        int numberOfLines = int.Parse(Console.ReadLine());

        if(numberOfLines < 1 && numberOfLines > 1000)
        {
            for(int i = 1; i <= numberOfLines; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }  
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
>>>>>>> 24933140f2ea2c9afe7adddd72647b8dd7fb8137
}