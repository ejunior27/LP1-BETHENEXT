using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP1.Aula6
{
    public class Dicionario
    {
        /*
         Usando dicionários, faça um robô que traduza uma linha de comando c# 
        para seu respectivo comando em português usando a tabela abaixo. 
        Alguns exemplos estão listados ao final.

            c#		português
            if		se
            while	enquanto
            >		maior que
            <		menor que
            >=		maior igual que
            <=		menor igual que
            ==		igual a
            !=		diferente de

        Exemplo 1
            input: if x > y
            output: se x maior que y
        Exemplo 2
            input: while x != y
            output: enquanto x diferente de y
         */

        static void Main1(string[] args)
        {
            Dictionary<string, string> dicionario = new();

            dicionario["if"] = "se";
            dicionario["while"] = "enquanto";
            dicionario[">"] = "maior que";
            dicionario["<"] = "menor que";
            dicionario[">="] = "maior igual que";
            dicionario["<="] = "menor igual que";
            dicionario["=="] = "igual a";
            dicionario["!="] = "diferente de";

            Console.WriteLine("Bem-vindo ao dicionário de comandos C#");
            Console.WriteLine("**************************************");
            Console.WriteLine();
            Console.WriteLine("Digite o comando C# que você quer traduzir:");

            string comando = Console.ReadLine();

            //string s = "aaa,bbb,ccc";           

            string[] comandos = comando.Split(" ");

            bool chaveEncontrada;

            string resposta = string.Empty;

            foreach (string cmd in comandos)
            {
                chaveEncontrada = dicionario.TryGetValue(cmd, out string traducao);

                if (chaveEncontrada)
                {
                    resposta += traducao + " ";
                }
                else
                {
                    resposta += cmd + " ";
                }
            }

            //resposta.Remove(resposta.Length - 1);

            Console.WriteLine($"A tradução do comando {comando} é {resposta.Trim()}.");
        }
    }
}
