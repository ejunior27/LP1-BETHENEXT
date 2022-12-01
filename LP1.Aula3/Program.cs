namespace LP1.Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nomes de variaveis
            /*
             * Não podemos utilizar palavras reservadas: for, if, else, while, string...
             * CamelCase: primeira minuscula, sem espaços, primeira letra da segunda
             * palavra maiúscula
             */

            //short - -32,768 ..32,767
            //Int16
            short numeroPequeno = -32767;

            numeroPequeno = 88;

            //int
            //Int32
            int numeroMedio = 20000;

            //long
            //Int64
            long numeroGrande = 300000;            

            //ushort
            ushort numeroPequenoPositivo = 65534;

            //uint
            uint numeroMedioPositivo = 555555;

            //ulong
            ulong numeroGrandePositivo = 10000000;

            //float - -3.402823e38 ..3.402823e38
            float pontoFlutuanteDaMorte = 1.6F;

            //double - -1.79769313486232e308 ..1.79769313486232e308
            double pontoFlutuanteMedio = 1.6;

            //decimal - -79228162514264337593543950335..79228162514264337593543950335
            decimal pontoFlutuanteGrande = 1.6M;

            //char - tudo q tem na tabela ASCII
            char apenasUmCaracter = 's';

            //string
            string qualquerTexto = "HelLo woRld!";
            string qualquerTexto2 = "c";
            string qualquerTexto3 = "Estou aprendendo C#!";

            //indices iniciam com zero

            //string qualquerTextoAlterado = qualquerTexto.Replace("!", "?");            
            //qualquerTexto = qualquerTexto.Replace("l", "r");
            int tamanhoDoTexto = qualquerTexto.Length;
            //Console.WriteLine(tamanhoDoTexto);

            qualquerTexto = qualquerTexto.ToLower();

            bool contemTexto = qualquerTexto.Contains("hello");           

            Console.WriteLine(qualquerTexto + qualquerTexto2);
            Console.WriteLine(contemTexto);
            //Console.WriteLine(qualquerTextoAlterado);

            //Kahoot

            //bool
            bool vBool = false;
            bool vBool2 = true;

            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);

        }
    }
}