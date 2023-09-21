using System;

namespace Aula_19_09_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;

            Console.Write("Informe a 1º Nota: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 2º Nota: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 3º Nota: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe a 4º Nota: ");
            nota4 = float.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            //0.00 a 4.99 - Reprovado
            //5.00 a 6.99 - Recuperação
            //7.00 a 10 - Aprovado


            if (media < 5) 
            {
                Console.Write("Reprovado!");
                Console.Write("\nPoxa que pena!");

            }
            else if (media < 7 )
            {
                Console.Write("Recuperação!");
                Console.Write("\nCoragem!!");
            }
            else 
            {
                Console.Write("Aprovado");
                Console.Write("\nParabens!!");
            }
        }
    }
}
