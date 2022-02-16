using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create By Daniel Oliveira");
            Console.WriteLine("Programa Que Retorna Nome, ID e Média Semestral do Aluno");

            Aluno_Dados("Lucas Gabriel", 1);
            Media_Aluno(8.2f, 9.4f, 3.5f);


            Console.ReadLine();
        }

        static void Media_Aluno(float a, float b, float c)
        {

            float media = (a + b + c) / 3;

            Console.WriteLine("E a media deste aluno é: " + media);

        }

        static void Aluno_Dados(string nome, int id)
        {
            
            Console.WriteLine("O Aluno com id " + id + " é o " + nome);

        }
    }
}
