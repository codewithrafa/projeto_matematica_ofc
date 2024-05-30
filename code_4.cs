namespace projeto_matematica_ofc
{
    public class code_4
    {
        //NÚMEROS PRIMOS

        public static bool numPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void Primos()
        {
            char cont = 's';
            while (cont == 's')
            {
                Console.Write("Digite um número inteiro positivo: ");
                int numero = int.Parse(Console.ReadLine());

                if (numPrimo(numero))
                {
                    Console.WriteLine("O número é primo.");
                }
                else
                {
                    Console.WriteLine("O número não é primo.");
                }
                Console.WriteLine("Deseja verificar outro número? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
