//judge.beecrowd.com/en/problems/view/1113

internal class Program
{
    private static void Main(string[] args)
    {
        bool differentNumbers = true;
		
		while(differentNumbers)
		{
			string[] input = Console.ReadLine()!.Split();
			
			int x = int.Parse(input[0]);
			int y = int.Parse(input[1]);
			
			if (x == y)
			{
				differentNumbers = false;
			}
			else
			{
				string order = x > y ? "Decrescente" : "Crescente";
				Console.WriteLine(order);
			}		
		}
    }
}