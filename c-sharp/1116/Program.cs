// judge.beecrowd.com/en/problems/view/1116

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
		
		for(int i = 0; i < n; i++)
		{
			string[] numbers = Console.ReadLine()!.Split();
			int x = int.Parse(numbers[0]);
			int y = int.Parse(numbers[1]);
			
			if(y == 0)
			{
				Console.WriteLine("divisao impossivel");
			}
			else
			{
				double result = (double) x / y;
				Console.WriteLine(result.ToString("F1", CultureInfo.InvariantCulture));
			}
		}
    }
}