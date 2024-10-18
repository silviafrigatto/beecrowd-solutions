using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int totalValidScores = 0;
		double sum = 0, average = 0;
				
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
    }
}