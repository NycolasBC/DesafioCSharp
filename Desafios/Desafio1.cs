using Desafio1_Rocketseat.Utilitarios;

namespace Desafio1_Rocketseat.Desafios
{
    internal class Desafio1
    {
        public static void CSharpDesafio1()
        {
            Console.WriteLine("\nDesafio 01:\n");

            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            string mensagemPersonalizada = $"Olá, {nome}! seja muito bem-vindo!";

            Utils.Printar(mensagemPersonalizada);
        }
    }
}
