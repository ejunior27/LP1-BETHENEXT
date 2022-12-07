namespace LP1.Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Conversão
            //Conversão de tipos

            //conversão implícita
            //short s = 5;
            //int i = s;

            //conversão explícita
            //cast
            //float d = 765.12f;
            //int i2 = (int)d;

            //classe Convert
            //int i = 12;
            //double d = 765.12;
            //float f = 56.123f;
            //string s = "15 6";

            //Console.WriteLine(Convert.ToString(f));
            //Console.WriteLine(Convert.ToInt32(d));
            //Console.WriteLine(Convert.ToUInt32(f));
            //Console.WriteLine(Convert.ToDouble(i));
            //Console.WriteLine(Convert.ToInt64(s));

            //Parse
            //string i = " 12 ";
            //string d = "765.12";
            //string f = "-56,123";
            //string s = "156";

            //Console.WriteLine(double.Parse(i));
            //Console.WriteLine(float.Parse(f));
            //Console.WriteLine(long.Parse(s));
            //Console.WriteLine(decimal.Parse(d));

            //TryParse
            //int i2 = 0;
            //bool conseguiuConverter = int.TryParse(d, out i2);
            //bool conseguiuConverter = double.TryParse(s, out double dSaida);
            //Console.WriteLine("Informe um valor inteiro:");
            //string valorDigitado = Console.ReadLine();

            //bool conseguiuConverter = int.TryParse(valorDigitado, out int intSaida);

            //Console.WriteLine(conseguiuConverter);
            //Console.WriteLine(intSaida);
            #endregion

            #region Condicionais
            //Estruturas condicionas/Estruturas de seleção

            //IF/ELSE
            //int n1, n2, n3, n4, soma;
            //n1 = n2 = n3 = n4 = soma = 0;
            //string resultado;

            //Console.Write("Digite a nota 1: ");
            //int.TryParse(Console.ReadLine(), out n1);

            //Console.Write("Digite a nota 2: ");
            //int.TryParse(Console.ReadLine(), out n2);

            //Console.Write("Digite a nota 3: ");
            //int.TryParse(Console.ReadLine(), out n3);

            //Console.Write("Digite a nota 4: ");
            //int.TryParse(Console.ReadLine(), out n4);

            //soma = n1 + n2 + n3 + n4;

            // < 40 - Reprovado
            // 40-59 - Recuperação
            // >= 60 - Aprovado

            //if (soma >= 60)
            //{
            //    resultado = "Aprovado";
            //}
            //else if(soma >= 40)
            //{
            //    resultado = "Recuperação";
            //}
            //else
            //{
            //    resultado = "Reprovado";
            //}

            //Console.WriteLine($"Nota final: {soma} - Resultado: {resultado}");

            //SWITCH/CASE

            //Console.WriteLine("Escolha uma seleção para descobrir à qual continente ela pertence.");
            //Console.WriteLine();
            //Console.WriteLine("[1]Brasil | [2]Catar | [3]Senegal | [4]Argentina | [5]Japão");
            //Console.WriteLine();

            //int.TryParse(Console.ReadLine(), out int escolha);
            //string continente;

            //switch (escolha)
            //{                
            //    case 1:
            //    case 4:
            //        continente = "América do Sul";                    
            //        break;
            //    case 2:
            //    case 5:
            //        continente = "Ásia";
            //        break;
            //    case 3:
            //        continente = "África";
            //        break;
            //    default:
            //        continente = "";
            //        break;
            //}

            //if (continente == "")
            //{
            //    Console.WriteLine("Seleção inválida");
            //}
            //else
            //{
            //    Console.WriteLine($"{continente} é o continente da seleção escolhida.");
            //}

            /*
            switch ("batata frita")
            {
                case (a > b):
                    {
                        echo "A é maior que B";
                        break;
                    }
                case (a < b):
                    {
                        echo "A é menor que B";
                        break;
                    }
                case (a == b):
                    {
                        echo "A é igual a B";
                        break;
                    }
                default:
                    {
                        echo "A é alguma coisa não comparável com B";
                    }
            }


            if ($a == 1) {
                echo 'Variável A é igual a 1';
            }
            else if ($a == 2) {
                echo 'Variável A é igual a 2';
            }
            else
            {
                echo 'A Variável A não é igual a 1 nem igual a 2';
            }
            */
            #endregion

            //Laços de repetição

            //for (inicializador; condição; incremento/decremento)
            //{

            //}

            //for(int contador = 0; contador < 5; contador++)
            //{
            //    Console.WriteLine(contador);
            //}

            int[] vetor = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            foreach (int valor in vetor)
            {
                if (valor == 5)
                {
                    //break;
                    continue;
                }
                Console.Write(valor);
            }
            //Console.WriteLine("digite algo:");
            //string escolha = Console.ReadLine();

            //while(escolha == "")
            //{
            //    Console.WriteLine("digite algo:");
            //    escolha = Console.ReadLine();
            //}

            //Console.WriteLine("obrigado!");

            //Break
            //Continue

            //string escolha;

            //do
            //{
            //    Console.WriteLine("digite algo:");
            //    escolha = Console.ReadLine();
            //} while (escolha == "");

            //Console.WriteLine("obrigado!");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}