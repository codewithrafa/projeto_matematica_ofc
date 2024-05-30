namespace projeto_matematica_ofc
{
    public class code
    {
        //OPERAÇÔES SIMPLES
        //SOMA, SUBTRAÇÃO, MULTIPLICAÇÃO, DIVISÃO, POTÊNCIA E RAÍZ QUADRADA
        public double n1;
        public double n2;
        public double Somar()
        {
            return n1 + n2;
        }
        public double Subtracao()
        {
            return n1 - n2;
        }
        public double Mult()
        {
            return n1 * n2;
        }
        public double Div()
        {
            return n1 / n2;
        }
        public double Potencia()
        {
            return Math.Pow(n1, n2);
        }
        public double Raiz()
        {
            return Math.Sqrt(Math.Pow(n1, n2));
        }

        public void OperacoesSimples()
        {
            char cont = 's';
            while (cont == 's')
            {
                Console.WriteLine("Digite o primeiro número: ");
                double.TryParse(Console.ReadLine(), out n1);
                Console.WriteLine("------------------------------");

                Console.WriteLine("Digite o segundo número: ");
                double.TryParse(Console.ReadLine(), out n2);
                Console.WriteLine("------------------------------");

                Console.WriteLine($"A soma dos números ({n1} + {n2}) é: {Somar()}");
                Console.WriteLine($"A subtração dos números ({n1} - {n2}) é: {Subtracao()}");
                Console.WriteLine($"A multiplicação dos números ({n1} x {n2}) é: {Mult()}");
                Console.WriteLine($"A potência do número {n1} elevado a {n2} é: {(decimal)Potencia()}");
                Console.WriteLine($"A raíz quadrada da potência {(decimal)Potencia()} é: {(decimal)Raiz()}\n");

                Console.WriteLine("Deseja realizar outro cálculo? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();
            }

        }

        internal void Teorema()
        {
            throw new NotImplementedException();
        }
    }
}
