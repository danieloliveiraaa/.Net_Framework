using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem();


            string [] produtos = new string[5] 
            {
                "God of War", //0 
                "FIFA", //1
                "Minecraft", //2
                "GTA V", //3
                "COD" //4
            };

            produtos[1] = "FIFA 2021"; //ATUALIZANDO VALOR DO ARRAY


            int[] valores = { 1, 2, 3, 4 }; //outra maneira de se criar um array

            Console.WriteLine(produtos[1]);
            
            Console.ReadLine();
        }

        static void Mensagem()
        {
            string msg = "Olá, agora vamos usar arrays";
            Console.WriteLine(msg);
        }


    }
}
