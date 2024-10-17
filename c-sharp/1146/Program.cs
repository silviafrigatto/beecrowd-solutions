<<<<<<< HEAD
﻿// https://judge.beecrowd.com/en/problems/view/1146

internal class Program
{
    private static void Main(string[] args)
    {
        int x;
		
		do
		{
			x = int.Parse(Console.ReadLine()!);

			for(int y = 1; y <= x; y++)
			{
				string output = (x == y) ? y + "\n" : y + " ";
				Console.Write(output);	
			}	
		} 
		while (x > 0);
		
		Environment.Exit(0);
    }
=======
﻿// https://judge.beecrowd.com/en/problems/view/1146

internal class Program
{
    private static void Main(string[] args)
    {
        int x;
		
		do
		{
			x = int.Parse(Console.ReadLine()!);

			for(int y = 1; y <= x; y++)
			{
				string output = (x == y) ? y + "\n" : y + " ";
				Console.Write(output);	
			}	
		} 
		while (x > 0);
		
		Environment.Exit(0);
    }
>>>>>>> 24933140f2ea2c9afe7adddd72647b8dd7fb8137
}