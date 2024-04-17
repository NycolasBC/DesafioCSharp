using Desafio1_Rocketseat.Utilitarios;
using System.Globalization;

namespace Desafio1_Rocketseat.Desafios
{
    internal class Desafio5
    {
        private static List<char> Letras = [
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z'];

        private static List<int> Numeros = [
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9];


        public static void CSharpDesafio5()
        {
            Console.WriteLine("\nDesafio 05:\n");

            Console.WriteLine("Informe uma placa de um veículo:");
            string placaVeiculo = Console.ReadLine();

            if(placaVeiculo.Length != 7)
            {
                Utils.Printar("É necessário ter 7 caracteres");
            }
            else
            {
                string tresPrimeirosCaracteres = placaVeiculo.Substring(0, 3);
                string quatroUltimosCaracteres = placaVeiculo.Substring(3, 4);

                if (VerificaLetras(tresPrimeirosCaracteres) && VerificaNumeros(quatroUltimosCaracteres))
                {
                    Utils.Printar("Verdadeiro");
                }
                else
                {
                    Utils.Printar("Falso");
                }
            }     
        }

        private static bool VerificaLetras(string caracteres)
        {
            string caracteresMaiusculos = caracteres.ToUpper();

            for (int i = 0; i < caracteresMaiusculos.Length; i++)
            {
                if (Letras.Contains(caracteresMaiusculos[i]))
                {
                    continue;
                }
                else
                {
                    return false;
                }           
            }
            return true;
        }

        private static bool VerificaNumeros(string numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                string numeroAtual = numeros[i].ToString();

                if (Numeros.Contains(Convert.ToInt32(numeroAtual)))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
