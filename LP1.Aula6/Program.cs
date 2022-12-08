using System.Collections;

namespace LP1.Aula6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary

            //Dictionary<int, string> dicNomes = new Dictionary<int, string>();
            Dictionary<int, string> dicNomes = new();

            //string[] nomes = new string[2];
            //nomes[0] = "Kaio";
            //nomes[1] = "Guilherme";

            //dicNomes.Add(1, new string[] { "nome1", "nome2", "nome3"});
            //dicNomes.Add(2, nomes);

            dicNomes.Add(83, "Rodrigo");
            dicNomes[83] = "Kaio";            
            
            dicNomes.Add(994, "Richard");
            dicNomes.Add(555, "Edson");
            dicNomes.Add(677, "Gustavo");

            int qtd = dicNomes.Count;

            var existeChave = dicNomes.ContainsKey(555);
            var existeValor = dicNomes.ContainsValue("Edson");

            var conseguiuPegar = dicNomes.TryGetValue(99, out string retorno);

            var removeu = dicNomes.Remove(88888, out string removido);
            //var existeChave = dicNomes.ContainsKey(677);

            //dicNomes[994] = "Lucas";

            foreach (KeyValuePair<int, string> par in dicNomes)
            {
                Console.WriteLine(par.Key);
                Console.WriteLine(par.Value);                
            }

            foreach ((int key, string val) in dicNomes)
            {
                Console.WriteLine($"{key} : {val}");
            }

            //Console.WriteLine(dicNomes);
            //Console.WriteLine(existeChave);

            Dictionary<int[], int[]> dic = new();

            foreach((int[] key, int[] value) in dic)
            {
                foreach(int i in key)
                {

                }

                foreach(int y in value)
                {

                }
            }

            //Console.Write($"D[{{{string.Join(',', arrPares)}}}]")
        }
    }
}