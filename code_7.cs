namespace projeto_matematica_ofc
{
    public class code_7
    {
        //MODA, MÉDIA E MEDIANA

        public static double Media(params int[] num)
        {
            double somaNum = 0;
            foreach (int n in num)
            {
                somaNum += n;
            }
            return somaNum / num.Length;
        }

        public static double Mediana(params int[] nums)
        {
            // Ordena os números
            Array.Sort(nums);

            // Verifica se a quantidade de números é ímpar
            if (nums.Length % 2 != 0)
            {
                // Se for ímpar, retorna o número central
                return nums[nums.Length / 2];
            }
            else
            {
                // Se for par, retorna a média dos dois números centrais
                int meio1 = nums.Length / 2;
                int meio2 = meio1 - 1;
                return (nums[meio1] + nums[meio2]) / 2.0;
            }

        }
        public static int Moda(params int[] numbers)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();

            foreach (int n in numbers)
            {
                if (freq.ContainsKey(n))
                {
                    freq[n]++;
                }
                else
                {
                    freq[n] = 1;
                }
            }
            int moda = 0;
            int freqMax = 0;

            foreach (var par in freq)
            {
                if (par.Value > freqMax)
                {
                    moda = par.Key;
                    freqMax = par.Value;
                }
            }
            return moda;
        }
        public void Centrais()
        {
            char cont = 's';
            while (cont == 's')
            {
                Console.WriteLine("Olá, selecione o que você quer calcular:\n" +
                "1 - Média\n" +
                "2 - Mediana\n" +
                "3 - Moda");
                int res = int.Parse(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        Console.WriteLine("Digite a quantidade de números do cálculo da média:\n");
                        int quant = int.Parse(Console.ReadLine());
                        int[] numeros = new int[quant];

                        for (int i = 0; i < quant; i++)
                        {
                            Console.WriteLine($"Digite o {i + 1}º número:");
                            numeros[i] = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine($"A média dos números é {Media(numeros)}");
                        break;

                    case 2:
                        Console.WriteLine("Digite a quantidade de números do cálculo da mediana:\n");
                        int quanti = int.Parse(Console.ReadLine());
                        int[] nums = new int[quanti];

                        for (int i = 0; i < quanti; i++)
                        {
                            Console.WriteLine($"Digite o {i + 1}º número:");
                            nums[i] = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        double mediana = Mediana(nums);
                        Console.WriteLine($"A mediana dos números é {mediana}");
                        break;

                    case 3:
                        Console.WriteLine("Digite a quantidade de números para o cálculo da moda:\n");
                        int quantidadeModa = int.Parse(Console.ReadLine());
                        int[] numerosModa = new int[quantidadeModa];

                        for (int i = 0; i < quantidadeModa; i++)
                        {
                            Console.WriteLine($"Digite o {i + 1}º número:");
                            numerosModa[i] = int.Parse(Console.ReadLine());
                        }

                        int moda = Moda(numerosModa);
                        Console.WriteLine($"A moda dos números é {moda}");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Selecione outra opção.");
                        break;
                }
                Console.WriteLine("Deseja realizar outro cálculo? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
