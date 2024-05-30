namespace projeto_matematica_ofc
{
    public class code_3
    {
        //Juros Simples
        // J = C * I * T
        // J -> Juros C -> Capital I -> taxa T -> tempo

        static double CalculoJurosSim(double c, double i, double t)
        {
            return c * (i / 100) * t;
        }

        static double CalculoJurosCom(double c2, double i2, double t2)
        {
            return c2 * Math.Pow((1 + (i2 / 100)), t2);
        }

        public void Juros()
        {
            char cont = 's';
            while (cont == 's')
            {
                Console.WriteLine("Olá. Vamos calcular juros simples ou compostos. \n");

                Console.WriteLine("Para começar, indique qual será o cálculo: \n" +
                    "1 - Cálculo de juros simples \n" +
                    "2 - Cálculo de juros compostos \n");
                int res = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (res)
                {
                    case 1:

                        Console.WriteLine("Informe o valor do capital (R$) investido:");
                        double c = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o valor da taxa (%) aplicado:");
                        double i = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a duração, em meses, do tempo aplicado:");
                        double t = Convert.ToDouble(Console.ReadLine());

                        double juros = CalculoJurosSim(c, i, t);
                        double capfinal = c + juros;
                        Console.WriteLine($"O valor do juros é: R$ {juros.ToString("C2")}");
                        Console.WriteLine($"Capital final (Montante): R$ {capfinal.ToString("C2")}");

                        break;

                    case 2:

                        Console.WriteLine("Informe o valor do capital (R$) investido:");
                        double c2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o valor da taxa (%) aplicado:");
                        double i2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a duração, em meses, do tempo aplicado:");
                        double t2 = Convert.ToDouble(Console.ReadLine());

                        double capfinal2 = CalculoJurosCom(c2, i2, t2); // MONTANTE
                        double juros2 = capfinal2 - c2; // J = M - C
                        Console.WriteLine($"O valor do juros é R$: {juros2.ToString("C2")}");
                        Console.WriteLine($"Capital final (Montante): R$ {capfinal2.ToString("C2")}");

                        break;

                    default:
                        Console.WriteLine("Opção inválida! Escolha uma opção válida.");
                        break;
                }

                Console.WriteLine("Deseja realizar outro cálculo? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}