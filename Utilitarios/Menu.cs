using Desafio1_Rocketseat.Desafios;

namespace Desafio1_Rocketseat.Utilitarios
{
    internal class Menu
    {
        public static void MenuGeral()
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("-------------- MENU GERAL --------------");
                Console.WriteLine
                    ("\nEscolha uma das opções:" +
                        "\n1 - Desafio 01" +
                        "\n2 - Desafio 02" +
                        "\n3 - Desafio 03" +
                        "\n4 - Desafio 04" +
                        "\n5 - Desafio 05" +
                        "\n6 - Desafio 06" +
                        "\n7 - Limpar console" +
                        "\n8 - Sair"
                    );
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Desafio1.CSharpDesafio1();

                        Console.WriteLine("\nAperte ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 2:
                        Desafio2.CSharpDesafio2();

                        Console.WriteLine("\nAperte ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 3:
                        Desafio3.CSharpDesafio3();

                        Console.WriteLine("\nAperte ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 4:
                        Desafio4.CSharpDesafio4();

                        Console.WriteLine("\nAperte ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 5:
                        Desafio5.CSharpDesafio5();

                        Console.WriteLine("\nAperte ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 6:
                        Desafio6.CSharpDesafio6();

                        Console.WriteLine("\nAperte ENTER para continuar...");
                        Console.ReadLine();
                        break;

                    case 7:
                        Console.Clear();
                        break;

                    case 8:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("\nDigite um valor válido!\n");

                        Console.WriteLine("\nAperte ENTER para continuar...");
                        Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("\nFim da aplicação! :)");
        }
    }
}