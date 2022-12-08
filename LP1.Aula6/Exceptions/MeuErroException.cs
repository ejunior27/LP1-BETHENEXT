using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1.Aula6.Exceptions
{
    public class MeuErroException : Exception
    {
        public MeuErroException(string mensagem) : base(mensagem)
        {
            
        }
    }
}
