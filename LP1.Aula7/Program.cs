namespace LP1.Aula7
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Métodos/Função

            /*
             Os métodos são geralmente o bloco de códigos ou instruções 
            em um programa que dá ao usuário a capacidade de reutilizar 
            o mesmo código que, em última análise, economiza o uso excessivo de memória, 
            atua como uma economia de tempo e, mais importante, 
            fornece uma melhor legibilidade do código. Então, basicamente, 
            um método é uma coleção de instruções que executam alguma tarefa 
            específica e retornam o resultado ao chamador. 
            Um método também pode realizar alguma tarefa específica sem retornar nada.
             */

            //Método = aquilo que não retorna um valor
            //Função = aquilo que retorna valor


            double xpto = CalcularAreaDoCirculo(10);
            

            Console.WriteLine(xpto);

            Console.WriteLine(ValidarNumeroPar(9));

            EscreverMensagem("Pansini");

            string frase = RetornarFraseAleatoria();

            Console.WriteLine(frase);

        }

        //Sintaxe de métodos
        //<Modificador de acesso> <tipo de retorno> <nome do método>([lista de parametros])
        static double CalcularAreaDoCirculo(double raio)
        {
            float pi = 3.14F;
            double area = pi * (raio * raio);

            return area;
        }

        static bool ValidarNumeroPar(int numero)
        {
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        static void EscreverMensagem(string nome, int dia)
        {
            Console.WriteLine($"Olá, {nome}! Hoje é dia {dia}");
        }        

        static void EscreverMensagem(string sobrenome)
        {
            Console.WriteLine($"Olá, Sr(a) {sobrenome}!");
        }

        static string RetornarFraseAleatoria()
        {
            return "Frase aleatória";
        }

        static void SomarNumeros()
        {
            var soma = 2 + 2;
        }
    }
}