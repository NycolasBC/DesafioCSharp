using Desafio1_Rocketseat.Utilitarios;

namespace Desafio1_Rocketseat.Desafios
{
    internal class Desafio4
    {
        public static void CSharpDesafio4()
        {
            Console.WriteLine("\nDesafio 04:\n");

            Console.WriteLine("Digite uma ou mais palavras:");
            string palavras = Console.ReadLine();

            string textoFinal = "";

            if (palavras.Contains(" "))
            {
                string palavrasSemEspacos = palavras.Replace(" ", "");
                textoFinal = $"A quantidade de caracteres das palavras são: {palavrasSemEspacos.Length}";
                Utils.Printar(textoFinal);
            }
            else
            {
                textoFinal = $"A quantidade de caracteres da palavras é: {palavras.Length}";
                Utils.Printar(textoFinal);
            }
        }
    }
}
