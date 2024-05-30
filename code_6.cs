namespace projeto_matematica_ofc
{
    public class code_6
    {

        /*   30°     45°     60°
        * SEN   1/2    √ 2/2   √ 3/2
        * COS  √ 3/2   √ 2/2     1/2
        * TAN  √ 3/3     1      √ 3
        */
        public static double CalculoSen(double c, double o, double h) //Cálculo do Seno: Oposto / Hipotenusa
        {
            double seno;
            switch (c)
            {
                case 30:
                    seno = ((1 / 2) * (o / h));
                    break;

                case 45:
                    seno = ((Math.Sqrt(2) / 2) * (o / h));
                    break;

                case 60:
                    seno = ((Math.Sqrt(3) / 2) * (o / h));
                    break;
                default:
                    Console.WriteLine("erro");
                    seno = 0;
                    break;
            }
            return seno;
        }


        static double CalculoCos(double c, double adj, double h) //Cálculo do Cosseno: Adjacente / Hipotenusa
        {
            double cos;
            switch (c)
            {
                case 30:
                    cos = ((Math.Sqrt(3) / 2) * (adj / h));
                    break;

                case 45:
                    cos = ((Math.Sqrt(2) / 2) * (adj / h));
                    break;

                case 60:
                    cos = ((1 / 2) * (adj / h));
                    break;

                default:
                    Console.WriteLine("Erro: Ângulo não suportado.");
                    cos = 0;
                    break;
            }
            return cos;
        }

        static double CalculoTan(double c, double o, double adj) //Cálculo da Tangente: Oposto / Adjacente
        {
            double tan;
            switch (c)
            {
                case 30:
                    tan = ((Math.Sqrt(3) / 3) * (o / adj));
                    break;

                case 45:
                    tan = (1 * (o / adj));
                    break;

                case 60:
                    tan = (Math.Sqrt(3) * (o / adj));
                    break;

                default:
                    Console.WriteLine("Erro: Ângulo não suportado.");
                    return 0;
            }
            return tan;
        }

        public void Trigonometria()
        {
            char cont = 's';
            while (cont == 's')
            {
                Console.WriteLine("Olá! Aqui, iremos calcular medidas trigonométricas. \n");

                Console.WriteLine("Para começar, indique qual será o cálculo: \n" +
                    "1 - Cálculo do seno \n" +
                    "2 - Cálculo do cosseno \n" +
                    "3 - Cálculo da tangente");
                int op = int.Parse(Console.ReadLine());

                double c, o, adj, h;

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do ângulo em graus (30°, 45° ou 60°) \n");
                        c = double.Parse(Console.ReadLine());

                        double anguloArredondado = Math.Round(c);

                        if (anguloArredondado != 30 && anguloArredondado != 45 && anguloArredondado != 60)
                        {
                            Console.WriteLine("Erro: Ângulo não suportado.");
                            break;
                        }

                        Console.WriteLine("Digite o valor do cateto oposto:");
                        o = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor da hipotenusa:");
                        h = double.Parse(Console.ReadLine());

                        Console.WriteLine($"O seno do ângulo {c}° é: {(CalculoSen(c, o, h))}");
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor do ângulo em graus (30°, 45° ou 60°):");
                        c = double.Parse(Console.ReadLine());

                        anguloArredondado = Math.Round(c);

                        if (anguloArredondado != 30 && anguloArredondado != 45 && anguloArredondado != 60)
                        {
                            Console.WriteLine("Erro: Ângulo não suportado.");
                            break;
                        }

                        Console.WriteLine("Digite o valor do cateto adjacente:");
                        adj = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor da hipotenusa:");
                        h = double.Parse(Console.ReadLine());

                        Console.WriteLine($"O cosseno do ângulo {c}° é: {(decimal)CalculoCos(c, adj, h)}");
                        break;

                    case 3:
                        Console.WriteLine("Digite o valor do ângulo em graus (30°, 45° ou 60°):");
                        c = double.Parse(Console.ReadLine());


                        double anguloArredondad = Math.Round(c);
                        if (anguloArredondad != 30 && anguloArredondad != 45 && anguloArredondad != 60)
                        {
                            Console.WriteLine("Erro: Ângulo não suportado.");
                            break;
                        }
                        Console.WriteLine("Digite o valor do cateto oposto:");

                        o = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do cateto adjacente:");
                        adj = double.Parse(Console.ReadLine());
                        Console.WriteLine($"A tangente do ângulo {c}° é: {(decimal)CalculoTan(c, o, adj)}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                Console.WriteLine("Deseja realizar outro cálculo? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();
            }

        }
    }
}
