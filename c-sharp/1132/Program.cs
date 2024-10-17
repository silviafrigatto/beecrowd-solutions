// judge.beecrowd.com/en/problems/view/1132

internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
		
		int x = int.Parse(Console.ReadLine()!);
		int y = int.Parse(Console.ReadLine()!);
		
		int smallest = Math.Min(x, y);
		int largest = Math.Max(x, y);
				
		for (int i = smallest; i <= largest; i++)
		{
			
			if ( i % 13 != 0)
			{
				sum += i;
			}
			
		}
		
		Console.WriteLine(sum);
    }
}