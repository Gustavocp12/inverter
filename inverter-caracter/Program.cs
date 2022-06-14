using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverter_caracter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();

            string nome_invertido = new string(nome.Reverse().ToArray());

            Console.WriteLine();
            Console.WriteLine(nome_invertido);

            Console.ReadKey();

        }
    }
}
