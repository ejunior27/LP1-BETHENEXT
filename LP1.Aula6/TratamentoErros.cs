using LP1.Aula6.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1.Aula6
{
    public class TratamentoErros
    {
        static void Main1(string[] args)
        {
            //Tratamento de erros
            //Try/Catch/Finally
            //Throw

            //throw new FormatException();

            try
            {
                //linha de código que pode disparar uma exceção
                var valor = Console.ReadLine();
                int numero = Convert.ToInt32(valor);
                int resultado = 100 / numero;                
                int soma = numero + 5;
                
                throw new MeuErroException("Explodiu meu erro");

                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException ex)
            {
                //linha de código que trata o erro
                Console.WriteLine($"Operação falhou. {ex.Message}.");
                //return 0;
            }
            catch (FormatException)
            {
                Console.WriteLine("Operação falhou. Número inválido.");                
            }
            catch (MeuErroException)
            {
                Console.WriteLine("Operação falhou. Meu erro estourou.");                
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Operação falhou. {ex.Message}.");
            //}
        }
    }
}
