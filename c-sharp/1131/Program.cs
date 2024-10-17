//judge.beecrowd.com/en/problems/view/1131

using _1131.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcao, totalGrenais = 0;
		Grenal partida = new Grenal();
		
		do
		{
			totalGrenais++;
			string[] placar = Console.ReadLine()!.Split();
			partida.GolsInter = int.Parse(placar[0]);
			partida.GolsGremio = int.Parse(placar[1]);
			
			partida.Resultado(partida.GolsInter, partida.GolsGremio);

			Console.WriteLine("Novo grenal (1-sim 2-nao)");
			
			opcao = int.Parse(Console.ReadLine()!);
			
			if(opcao == 2)
			{
				Console.WriteLine(totalGrenais + " grenais");
				Console.WriteLine("Inter:" + partida.VitoriaInter);
				Console.WriteLine("Gremio:" + partida.VitoriaGremio);
				Console.WriteLine("Empates:" + partida.Empate);
				if(partida.VitoriaInter != partida.VitoriaGremio)
				{
					Console.WriteLine(partida.VitoriaInter > partida.VitoriaGremio ? "Inter venceu mais" : "Gremio venceu mais");
				}
				else
				{
					Console.WriteLine("Nao houve vencedor");
				}			
			}
		}
		while(opcao == 1);
    }
}