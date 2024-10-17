//judge.beecrowd.com/en/problems/view/1118

using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int totalValidScores = 0, x;
		double sum = 0, average = 0;
		bool programRunning = true;
		
		while(programRunning)
		{
			while(totalValidScores != 2)
			{
				double score = double.Parse(Console.ReadLine()!);

				if(score < 0 || score > 10)
				{
					Console.WriteLine("nota invalida");
				}
				else
				{	
					totalValidScores ++;
					sum += score;
				}
			}

			average = sum / 2;
			Console.WriteLine("media = " + average.ToString("F2", CultureInfo.InvariantCulture));

			do
			{
				Console.WriteLine("novo calculo (1-sim 2-nao)");
				x = int.Parse(Console.ReadLine()!);
			}
			while(x < 1 || x > 2 );

			if( x == 1 )
			{
				totalValidScores = 0;
				sum = 0;
			}
			
			if( x == 2 )
			{
				programRunning = false;
			}
		}
    }
}