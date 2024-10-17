using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1131.Models
{
    public class Grenal
    {
        public int GolsInter;
        public int GolsGremio;
        public int VitoriaInter;
        public int VitoriaGremio;
        public int Empate;
        
        public void Resultado(int GolsInter, int GolsGremio)
        {
            if(GolsInter > GolsGremio)
            {
                VitoriaInter++;
            }
            else if(GolsInter < GolsGremio)
            {
                VitoriaGremio++;
            }
            else
            {
                Empate++;
            }
        }
    }
}