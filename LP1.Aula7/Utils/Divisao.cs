using LP1.Aula7.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1.Aula7.Utils
{
    public static class Divisao
    {
        public static double DividePor100(int numero)
        {
            try
            {
                return 100 / numero;
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}
