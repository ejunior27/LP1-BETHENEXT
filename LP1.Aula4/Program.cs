using System.Text;

namespace LP1.Aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DateTime
            /*
            //DateTime data = new DateTime();
            DateTime agora = DateTime.Now;
            //DateTime minhaData = new DateTime(1980, 12, 27, 8, 0, 0);
            
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(agora.Month);
            Console.WriteLine(agora.Day);
            Console.WriteLine(agora.Hour);
            Console.WriteLine(agora.Minute);
            Console.WriteLine(agora.Second);
            Console.WriteLine(agora.Millisecond);
            Console.WriteLine(agora.DayOfWeek);
            Console.WriteLine(agora.DayOfYear);

            Console.WriteLine();

            Console.WriteLine(agora.ToString()); //30/11/2022 19:53:45
            Console.WriteLine(agora.ToLongDateString()); //quarta-feira, 30 de novembro de 2022
            Console.WriteLine(agora.ToShortDateString()); //30/11/2022
            Console.WriteLine(agora.ToLongTimeString()); //19:53:45
            Console.WriteLine(agora.ToShortTimeString()); //19:53

            string dataLonga = agora.ToLongDateString();  
            */
            #endregion

            #region Concatenação de strings
            //string s1 = "Usando";
            //string s2 = "sinal";
            //string s3 = "de soma";
            //string s4 = "para concatenar";

            //string s5 = s1 + " " + s2 + " " + s3 + " " + s4;

            int i1 = 4;
            string csharp = "c#";
            string hora = DateTime.Now.ToShortTimeString();

            //string s6 = string.Format("Usando sinal de soma para concatenar. Aula {0} {1} {2}", 
            //                            i1, 
            //                            "C#", 
            //                            DateTime.Now.ToShortTimeString()); 

            string s7 = $"Usando sinal \n de soma para concatenar. Aula {5 + 10} asdfsd {csharp} asdfsdf {hora}";

            StringBuilder sb1 = new StringBuilder();

            sb1.Append("xpto\n");
            sb1.AppendLine("aaaa");

            var s8 = sb1.ToString();
            #endregion

            #region Vetores
            int[] vetor = new int[10] {1,2,3,4,5,6,7,8,9,10};
            string[] frutas = new string[3] {"Banana", "Maçã", "Pêra"};

            frutas[0] = "Kiwi";

            DateTime[] listaData = new DateTime[20];

            int[,] matriz = new int[2, 3] { { 50,20,30 }, { 80,90,10 } };

            matriz[0, 2] = 150;

            #endregion

            //Operadores Aritméticos
            // + adição
            // - subtração
            // * multiplicação
            // / divisão
            // % módulo

            //int a = 5, b = 10, c = 15, d = 20;

            //Console.WriteLine(a + b);
            //Console.WriteLine(c - a);
            //Console.WriteLine(b * c);
            //Console.WriteLine(d / b);
            //Console.WriteLine(c % b);
            //Console.WriteLine(Math.Pow(2, 4));

            //Console.WriteLine(a + b * c);
            //Console.WriteLine((a + b) * c);

            //Operadores de atribuição reduzidos
            // += 
            // -=
            // *=
            // /=
            // %=

            //int x = 5;
            //Console.WriteLine(x += 5);
            //Console.WriteLine(x -= 2);
            //Console.WriteLine(x *= 10);
            //x += 5; //x = x + 5


            //Operadores incrementais e decrementais
            // ++
            // --

            //int y = 10;
            //int z = 10;
            //y++;
            //z--;
            //Console.WriteLine(++y);
            //Console.WriteLine(--z);

            //y++; // y = y + 1
            //y--; // y = y - 1

            //Operadores relacionais
            // == Igua a
            // != Diferente de
            // > Maior que
            // < Menor que
            // >= Maior do que ou igual a
            // <= Menor do que ou igua a

            //int a = 10, b = 25, c = 50, d = 100;
            //Console.WriteLine(a == d);
            //Console.WriteLine(b != c);
            //Console.WriteLine(a > b);
            //Console.WriteLine(c < d);
            //Console.WriteLine(c >= a);
            //Console.WriteLine(d <= b);

            //Operadores lógicos
            // && AND (E)
            // || OR (OU)
            // ! NOT (NÃO)

            //int a = 5, b = 10, c = 15, d = 20;
            //Console.WriteLine(a == 5 && d == 10);
            //Console.WriteLine(c < 5 || d == 20);
            //Console.WriteLine(! (b>a));

            //Operadores ternários
            int x = 5, y = 10;            

            //string resposta = x < y ? (y > 15 ? "é": "não é") : "não";
            string resposta = x < y ? "sim" : "não";

            Console.WriteLine(resposta); // [operação relacional(falso, verdadeiro)] ? [retorno caso positivo] : [retorno caso negativo]


            //Console.WriteLine(matriz);

            //Console.WriteLine(frutas[frutas.Length - 1]);

            Console.ReadKey();
        }
    }
}