using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int
            bool
            float 
            string ""
            */

            //var meuTexto = "Hello World - Daniel Oliveira";

            //int segundaGuerra = 1942;


            //const float PI = 3.145565656f; //numeros floats precisam do 'f' no final

            //Console.WriteLine(meuTexto);

            //WRITE ESCREVO
            //Console.WriteLine("Olá MUndo");
            //Console.WriteLine("Meu nome é Daniel Oliveira");
            //READ LINE FICA ESPERANDO O USUARIO
            //APERTAR ENTER
            //Console.ReadLine();









            /*
            string nome = "";

            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();//variavel nome recebe o que foi lido
            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            Console.ReadLine();
            */





            //CONDICIONAL
            /*
            if (10 > 2000)
            {
                Console.WriteLine("É verdade!");
            }
            else
            {
                Console.WriteLine("É mentira!");
            }
                Console.ReadLine();
            */


            /*
            ExibirMsg();

            GerarPreco(60); //tem que passar um valor
            */
            int soma = Somar(10, 10);

            Console.WriteLine(soma);

            Console.ReadLine();
        }


        static void ExibirMsg()//função que nao retorna nada
        {
            Console.WriteLine("Esse sistem é bom");
            Console.WriteLine("Funções");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Daniel Oliveira");
        }


        static void GerarPreco(int preco)
        {
            //EXTRAIR O VALOR POSITIVO DE UM NUMERO
            //ABS
            int precoAbs = Math.Abs(preco); 
            int valorFinal = preco + (2 * preco);

            Console.WriteLine("Valor final " + valorFinal);
        }


        static int Somar(int a, int b)
        {
            int resultadoFinal = a + b;

            //Console.WriteLine("A soma de a e b é: "+resultadoFinal);

            return resultadoFinal;
        }
    }
}
