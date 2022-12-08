using LP1.Aula7.Exceptions;
using LP1.Aula7.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1.Aula7
{
    public class Metodos
    {
        static void Main(string[] args)
        {            
            var valor = Console.ReadLine();

            int numero = Conversao.RecebeConverteNumero(valor);
            double resultado = Divisao.DividePor100(numero);

            Console.WriteLine(resultado);            
        }       
    }
}
