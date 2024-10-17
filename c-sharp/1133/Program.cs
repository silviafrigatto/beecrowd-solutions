// judge.beecrowd.com/en/problems/view/1133

internal class Program
{
    private static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine()!);
		int y = int.Parse(Console.ReadLine()!);
		
		int max = Math.Max(x, y);
		int min = Math.Min(x, y);
		
		for (int i = min + 1; i < max; i++)
		{
			if (i % 5 == 2 || i % 5 == 3)
			{
				Console.WriteLine(i);
			}
		}
    }
}