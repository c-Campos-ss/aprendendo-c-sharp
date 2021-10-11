using System;
using System.Collections.Generic;
using System.Linq;                   
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program // Início do programa
    {
        static void Main(string[] args)
        {
            int ageCaua = 15;
            Console.Write("A idade de Cauã é " + ageCaua); // Mostra a idade de Cauã (15).

            Console.Write("\n\nDigite sua idade: "); 
            int ageUsuario = Convert.ToInt32(Console.ReadLine()); // Permite ao usário digitar sua idade, convertendo para inteiro.

            if (ageUsuario == ageCaua) {
                Console.Write("\nVocê tem a mesma idade que Cauã."); // Testa se a idade do usuário é igual a de Cauã.
            }
            else if (ageUsuario > ageCaua) {
                Console.Write("\nVocê é mais velho que Cauã."); // Caso a idade não seja igual, testa se ela é maior.
            }
            else {
                Console.Write("\nVocê é mais novo que Cauã."); // Caso a idade não seja maior, não é necessário mais teste, o usuário é mais novo.
            }

        }
    } // Fim do programa
}