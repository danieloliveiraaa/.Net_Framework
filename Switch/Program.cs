using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor = "Azul";

            //SO REALIZA IGUALDADE
            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Vermelho");
                    break;
                case "Branco":
                    Console.WriteLine("Branco");
                    break;
                //valor default padrao caso nao caia em nenhuma!
                default:
                    Console.WriteLine("Não sei sua cor");
                    break;
            }

            Console.ReadLine();
        }
    }
}
