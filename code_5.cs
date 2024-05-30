namespace projeto_matematica_ofc
{
    public class code_5
    {
        //ÁREA DO TRIÂNGULO
        public double b; // base menor
        public double B; // base maior
        public double h; // altura
        public double l; // lado
        public double d; // diagonal menor
        public double D; // diagonal maior
        public double r; // raio

        public double CalculoTri()
        {
            return (b * h) / 2;
        }
        public double CalculoRet()
        {
            return (b * h);
        }
        public double CalculoQuad()
        {
            return (l * l);
        }
        public double CalculoTrap()
        {
            return ((b + B) * h / 2);
        }
        public double CalculoLosan()
        {
            return D * d / 2;
        }
        public double CalculoCirc()
        {
            return Math.PI * (r * r);
        }
        public void Geo()
        {
            char cont = 's';
            while (cont == 's')
            {
                Console.WriteLine("Olá. Vamos calcular a área de poligonos planos. \n");

                Console.WriteLine("Para começar, indique a figura plana para o cálculo: \n" +
                    "1 - Quadrado \n" +
                    "2 - Triângulo \n" +
                    "3 - Retângulo \n" +
                    "4 - Trapézio \n" +
                    "5 - Losango \n" +
                    "6 - Círculo \n");
                int res = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (res)
                {
                    case 1:
                        Console.WriteLine("Digite a medida do lado do quadrado:");
                        double.TryParse(Console.ReadLine(), out l);
                        Console.WriteLine("------------------------------");

                        Console.Clear();
                        Console.WriteLine($"A área do quadrado é: {CalculoQuad()}");
                        break;

                    case 2:
                        Console.WriteLine("Digite a base do triângulo:");
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("------------------------------");

                        Console.WriteLine("Digite a altura do triângulo:");
                        double.TryParse(Console.ReadLine(), out h);
                        Console.WriteLine("------------------------------");

                        Console.Clear();
                        Console.WriteLine($"A área do triângulo é: {CalculoTri()}");
                        break;

                    case 3:
                        Console.WriteLine("Digite a base do retângulo:");
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("------------------------------");

                        Console.WriteLine("Digite a altura do retângulo:");
                        double.TryParse(Console.ReadLine(), out h);
                        Console.WriteLine("------------------------------");

                        Console.Clear();
                        Console.WriteLine($"A área do retângulo é: {CalculoRet()}");
                        break;

                    case 4:
                        Console.WriteLine("Digite a base menor (b) do trapézio:");
                        double.TryParse(Console.ReadLine(), out b);
                        Console.WriteLine("------------------------------");

                        Console.WriteLine("Digite a base maior (B) do trapézio:");
                        double.TryParse(Console.ReadLine(), out B);
                        Console.WriteLine("------------------------------");

                        Console.WriteLine("Digite a altura do trapézio:");
                        double.TryParse(Console.ReadLine(), out h);
                        Console.WriteLine("------------------------------");

                        Console.Clear();
                        Console.WriteLine($"A área do trapézio é: {CalculoTrap()}");
                        break;

                    case 5:
                        Console.WriteLine("Digite a diagonal menor (d) do losango:");
                        double.TryParse(Console.ReadLine(), out d);
                        Console.WriteLine("------------------------------");

                        Console.WriteLine("Digite a diagonal maior (D) do losango:");
                        double.TryParse(Console.ReadLine(), out D);
                        Console.WriteLine("------------------------------");

                        Console.Clear();
                        Console.WriteLine($"A área do losango é: {CalculoLosan()}");
                        break;

                    case 6:
                        Console.WriteLine("Digite a metade do diâmetro (raio) do círculo:");
                        double.TryParse(Console.ReadLine(), out r);
                        Console.WriteLine("------------------------------");

                        Console.Clear();
                        Console.WriteLine($"A área do círculo é: {CalculoCirc()}");
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
