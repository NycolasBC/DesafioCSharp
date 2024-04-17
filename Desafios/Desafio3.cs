using Desafio1_Rocketseat.Utilitarios;

namespace Desafio1_Rocketseat.Desafios
{
    internal class Desafio3
    {
        public static void CSharpDesafio3()
        {
            Console.WriteLine("\nDesafio 03:\n");

            Console.WriteLine("Digite o primeiro número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double soma = Utils.Soma(numero1, numero2);
            double subtracao = Utils.Subtracao(numero1, numero2);
            double multiplicacao = Utils.Multiplicacao(numero1, numero2);
            double divisao = Utils.Divisao(numero1, numero2);
            double media = Utils.Media(numero1, numero2);

            string resultadoDivisao = "";

            if (Double.IsNaN(divisao))
            {
                resultadoDivisao = "Impossível dividir um número por zero!";
            }

            string resultadoFinal = $"O resultado da soma é: {soma}, " +
                $"da subtração: {subtracao}, " +
                $"da multiplicação: {multiplicacao}, " +
                $"da divisão: {(resultadoDivisao == "" ? divisao : resultadoDivisao)} " +
                $"e da média: {media}";

            Utils.Printar(resultadoFinal);
        }
    }
}
