using LP1.Aula7.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1.Aula7.Utils
{
    public static class Conversao
    {
        //Private: Com este modificador, o acesso é permitido somente dentro da classe onde ele foi declarado.
        //Por padrão, é a visibilidade definida para métodos e atributos em uma classe.

        public static int RecebeConverteNumero(string valor)
        {
            try
            {
                var valor2 = BuscaNoBanco();
                return Convert.ToInt32(valor);
            }
            catch (Exception)
            {
                return default;
            }
        }

        private static string BuscaNoBanco()
        {
            return "valor do banco";
        }

        static void fazAlgumacoisa()
        {
            RecebeConverteNumero("");
        }
    }
}
