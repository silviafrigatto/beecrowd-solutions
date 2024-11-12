
//judge.beecrowd.com/en/problems/view/1149

internal class Program
{
    private static void Main(string[] args)
    {
        int r = 1;
        int somaDosConsecutivos = 0;
        string input = Console.ReadLine()!;
        string[] valores = input.Split(' ');   

        if (valores.Length == 2 && int.TryParse(valores[0], out int a) && int.TryParse(valores[1], out int n))
        {
            do
            {
                n = int.Parse(Console.ReadLine()!);
            } while (n <= 0);

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