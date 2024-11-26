internal class Program
{
    private static void Main(string[] args)
    {
        int x = int.Parse(Console.ReadLine()!);
        int z = int.Parse(Console.ReadLine()!);
        //int count = 0;

        if(x < z)
        {
            // for(count = 0; z > x; count++)
            // {
            //     x += 1;
            // }
            while(z > x)
            {
                x += 1;
                //count++;
            }
            Console.WriteLine(x);
        }
        else
        {
            while(z <= x)
            {
                z = int.Parse(Console.ReadLine()!);
            }
        } 
        
    }
}