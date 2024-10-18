// judge.beecrowd.com/en/problems/view/1099

internal class Program
{
    private static void Main(string[] args)
    {
        int  a, x, y, count = 0, sumOdds = 0;
		
		int n = int.Parse(Console.ReadLine()!);
		
		int[] odds = new int[n];
		
		while (count < n)
		{
			string[] interval = Console.ReadLine()!.Split();
			x = int.Parse(interval[0]);
			y = int.Parse(interval[1]);
			
			if(x > y)
			{
				for (a = (x - 1); a > y; a--)
				{
					if (a % 2 != 0)
					{
						sumOdds += a;
					}	
				}
				odds[count] = sumOdds;
				sumOdds = 0;
			}
			
			else if(x < y)
			{
				for (a = (x + 1); a < y; a++)
				{
					if (a % 2 != 0)
					{
						sumOdds += a;
					}
						
				}
				odds[count] = sumOdds;
				sumOdds = 0;
			}	
			
			else
			{
				sumOdds = 0;
				odds[count] = sumOdds;
			}
			
			count++;
			
		}
		
		for (int i = 0; i < odds.Length; i++)
		{
			Console.WriteLine(odds[i]);
		}
    }
}