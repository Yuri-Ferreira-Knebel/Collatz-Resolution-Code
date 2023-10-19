using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1_tet
{

    class Program
    {
        static void Main()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            while (numero != 1)
            {
                if (numero % 2 == 1) // Verifica se o número é ímpar
                {
                    Console.WriteLine(numero);
                    numero = numero * 3 + 1;
                }
                else // O número é par
                {
                    Console.WriteLine(numero);
                    numero = numero / 2;
                }
            }

            Console.WriteLine(numero);
            Console.ReadKey();
        }

       
    }


}
