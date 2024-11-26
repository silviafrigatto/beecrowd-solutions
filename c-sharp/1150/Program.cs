internal class Program
{
    private static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine()!);
        int z = int.Parse(Console.ReadLine()!);
        //int count = 0;

        while(z <= x)
        {
            z = int.Parse(Console.ReadLine()!);
        }
       
        for(int i = x; i < z; i++)
        {
            Console.WriteLine(i);
        }          
    }
}