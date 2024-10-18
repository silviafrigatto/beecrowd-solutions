// judge.beecrowd.com/en/problems/view/1114

internal class Program
{
    private static void Main(string[] args)
    {
        int password;
		
		do
		{
			password = int.Parse(Console.ReadLine()!);
			string access = password != 2002 ? "Senha Invalida" : "Acesso Permitido";
			Console.WriteLine(access);
		}
		while(password != 2002);
    }
}