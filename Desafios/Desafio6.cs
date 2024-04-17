using Desafio1_Rocketseat.Utilitarios;
using System.Globalization;

namespace Desafio1_Rocketseat.Desafios
{
    internal class Desafio6
    {
        public static void CSharpDesafio6()
        {
            Console.WriteLine("\nDesafio 06:\n");

            DateTime dataAgora = DateTime.UtcNow;

            CultureInfo cultureBR = new CultureInfo("pt-BR");

            string formatoCompleto = dataAgora.ToString("dddd, dd MMMM yyyy HH:mm:ss", cultureBR);
            string formatoDiaMesAno = dataAgora.ToString("dd/MM/yyyy", cultureBR);
            string formatoHoras = dataAgora.ToString("HH:mm", cultureBR);
            string formatoMesExtenso = dataAgora.ToString("dd MMMM yyyy", cultureBR);

            string resultadoFinal = $"Datas do momento atual formatadas:" +
                $"\n\n{formatoCompleto}" +
                $"\n{formatoDiaMesAno}" +
                $"\n{formatoHoras}" +
                $"\n{formatoMesExtenso}";

            Utils.Printar(resultadoFinal);
        }
    }
}
