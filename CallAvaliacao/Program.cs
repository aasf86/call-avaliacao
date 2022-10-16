using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallAvaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;//String, literal ou caracter

            Console.WriteLine("Call de avaliação");
            Console.WriteLine("Digite seu nome:");            
            nome = Console.ReadLine();
            Console.WriteLine($"Seu nome é: {nome}");
            Console.ReadKey();

            //-------------------
            
            int idade = 36;//numero inteiro não fracionado
            decimal quantoDolarEleTem = 3659646.69m;//numero fracionado
            bool casado = true;//boleana true/false => verdadeiro/falso
            string[] filhos = new string[] { "Luis", "Heloisa", "Benjamin" };
            //vetor, array ou list
            /*
            filhos[0]
            filhos[1]
            filhos[2]
            filhos[3]
            */
            var count = 0;

            while (count < 1000)
            {                
                Console.WriteLine($"{count} => Eu sou mais bonito que o gabriel...");
                count = count + 1;
            }

            count = 0;

            while (count < filhos.Length)
            {
                string item = filhos[count];
                Console.WriteLine($"{count + 1}º filho: {item}");
                count = count + 1;
            }


            for (int i = 0; i < filhos.Length; i++)
            {
                string item = filhos[i];
                Console.WriteLine($"{i+1}º filho: {item}");
            }

            count = 1;

            foreach (var item in filhos)
            {
                Console.WriteLine($"{count}º filho: {item}");
                count = count + 1;
            }

            Console.WriteLine($"Estes são os filhos do {nome}");

            Console.WriteLine($"Pressione qualquer teclar para sair...xau!!!");
            Console.ReadKey();
        }
    }
}
