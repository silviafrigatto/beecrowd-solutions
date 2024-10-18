// judge.beecrowd.com/en/problems/view/1101

internal class Program
{
    private static void Main(string[] args)
    {
        bool doThis = true;
		
		while(doThis)
		{
			string[] input = Console.ReadLine()!.Split();

			int num1 = int.Parse(input[0]);
			int num2 = int.Parse(input[1]);

			int sum = 0;

			List<int> consecutives = new List<int>();
			
			if (num1 <= 0 || num2 <= 0)
			{
				doThis = false;
			}
			
			else
			{
				if (num1 > num2)
				{
					sum = num2;
					consecutives.Add(num2);
					while(num2 < num1)
					{	
						num2++;
						sum += num2;
						consecutives.Add(num2);
					}
				}

				else
				{
					sum = num1;
					consecutives.Add(num1);
					while(num1 < num2)
					{
						num1++;
						sum += num1;
						consecutives.Add(num1);
					}
				}

				foreach (int number in consecutives)
				{
					Console.Write(number + " ");
				}

				Console.WriteLine("Sum=" + sum);

			}
				
		}
    }
}