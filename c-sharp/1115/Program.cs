// judge.beecrowd.com/en/problems/view/1115

internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;
		bool notZero = true;
		
		while(notZero)
		{
			string[] coordinates = Console.ReadLine()!.Split();
			x = int.Parse(coordinates[0]);
			y = int.Parse(coordinates[1]);
			
			if (x > 0 && y > 0)
			{
				Console.WriteLine("primeiro");	
			}
			else if (x < 0 && y > 0)
			{
				Console.WriteLine("segundo");
			}
			else if (x < 0 && y < 0)
			{
				Console.WriteLine("terceiro");
			}
			else if (x > 0 && y < 0)
			{
				Console.WriteLine("quarto");
			}
			else
			{
				notZero = false;
			}		
		}
    }
}