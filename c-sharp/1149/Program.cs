
//judge.beecrowd.com/en/problems/view/1149

internal class Program
{
    private static void Main(string[] args)
    {
        int r = 1;
        int somaDosConsecutivos = 0;
        string inputString = Console.ReadLine()!;
        string[] valores = inputString.Split(' ');  
        int[] inputInt = Array.ConvertAll(valores, int.Parse); 

        Console.WriteLine(inputInt[0] + " " + inputInt[1]);

        int a = inputInt[0];
        int n = inputInt[1];   

        while ( a <= 0 && n <= 0) 
        {
            
        }

        if (valores.Length == 2 && int.TryParse(valores[0], out int a) && int.TryParse(valores[1], out int n))
        {
            // do
            // {
            //     n = int.Parse(Console.ReadLine()!);
            // } while (n <= 0);

            // while (n <= 0)
            // {
            //     n = int.Parse(Console.ReadLine()!);
            // }

            for (int i = 0; i < n; i++)
            {
                int termo = a + i * r;  // Formula PA
                //Console.WriteLine(termo);
                somaDosConsecutivos += termo;
            } 
            Console.WriteLine(somaDosConsecutivos);    
        }   
        else
        {
            Console.WriteLine("Por favor, digite dois números válidos, com um espaço entre eles.");
        }      
    }
}