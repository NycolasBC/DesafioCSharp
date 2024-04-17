using Desafio1_Rocketseat.Utilitarios;

namespace Desafio1_Rocketseat.Desafios
{
    internal class Desafio2
    {
        public static void CSharpDesafio2()
        {
            Console.WriteLine("\nDesafio 02:\n");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite seu sobrenome:");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = String.Join(" ", nome, sobrenome);

            Utils.Printar(nomeCompleto);
        }
    }
}
