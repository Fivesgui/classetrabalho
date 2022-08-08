using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semaforocaiogui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome da pessoa:"); string n = Console.ReadLine();
            Console.Write("Digite a idade de {0}:", n); int i = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura de {0}:", n); double a = double.Parse(Console.ReadLine());
            Console.Write("Digite a letra correspondente ao sexo(F/M):");
            char s= char.Parse(Console.ReadLine));

           Pessoa pessoa = new Pessoa(n,i,a,s);
            Console.Write("\n\n*** Dados da Pessoa ***\n");
            Console.WriteLine(pessoa.ToString());

            pessoa.Nome = "Caio";

            Console.WriteLine(" Peso Ideal: {0}", pessoa.calcularPesoIdeal());
            Console.ReadKey();
        }
    }
}
