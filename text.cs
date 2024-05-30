namespace projeto_matematica_ofc
{

    public class text
    {
        /* CÓDIGO DE EXECUÇÃO DO PROJETO MATEMÁTICA */
        // Criado por Rafael Carvalho em 23/09/2023

        static void Main()
        {
            bool continuar = true;
            while (continuar)
            {
                int escolha;
                Console.WriteLine("Escolha uma área da matemática:\n 1 - Operações básicas\n 2 - Teorema de pitágoras\n 3 - Cálculo de Juros\n " +
                "4 - Números primos\n 5 - Geometria plana \n 6 - Trigonometria \n 7 - Medidas de tendência central");

                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.Clear();
                    switch (escolha)
                    {
                        case 1:
                            code executar = new code();
                            executar.OperacoesSimples();
                            break;
                        case 2:
                            code_2 executar2 = new code_2();
                            executar2.Teorema();
                            break;
                        case 3:
                            code_3 executar3 = new code_3();
                            executar3.Juros();
                            break;
                        case 4:
                            code_4 executar4 = new code_4();
                            executar4.Primos();
                            break;
                        case 5:
                            code_5 executar5 = new code_5();
                            executar5.Geo();
                            break;
                        case 6:
                            code_6 executar6 = new code_6();
                            executar6.Trigonometria();
                            break;

                        case 7:
                            code_7 executar7 = new code_7();
                            executar7.Centrais();
                            break;
                        default:
                            Console.WriteLine("Opção inválida.Por favor, insira um número válido.");
                            break;
                    }
                    Console.WriteLine("Deseja selecionar outra área da matemática? (s/n)");
                    string resposta = Console.ReadLine().ToLower();
                    continuar = (resposta == "s");
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, insira um número válido.");
                }
            }
        }
    }
}