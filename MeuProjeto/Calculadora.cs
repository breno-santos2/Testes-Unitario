using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MeuProjeto
{
    public class Calculadora
    {
        private readonly List<string> ListaHistorico;
        private readonly string Data;

        public Calculadora(string Data)
        {
            ListaHistorico = new List<string>();
             this.Data = Data;
        }
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            ListaHistorico.Insert(0, "Res:" + res + " - Data:"  + Data);
            return res;
        }
         public int Subtrair(int val1, int val2)
        {
            
            int res = val1 - val2;
            ListaHistorico.Insert(0, "Res:" + res + " - Data:"  + Data);
            return res;
            
        }
         public int Multiplicar(int val1, int val2)
        {
            
            int res = val1 * val2;
           ListaHistorico.Insert(0, "Res:" + res + " - Data:"  + Data);
            return res;
        }
         public int Dividir(int val1, int val2)
        {
            if (val2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            
            int res = val1 / val2;
            ListaHistorico.Insert(0, "Res:" + res + " - Data:"  + Data);
            return res;
        }

        public List<string> Historico()
        {

            if (ListaHistorico.Count > 3)
            {
                ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            }
                return ListaHistorico;
        }
    

    }
}
