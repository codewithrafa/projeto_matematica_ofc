namespace projeto_matematica_ofc
{
    public class code_2
    {
        /*TEOREMA DE PITÁGORAS
         * c ^ 2 = a ^ 2 + b ^ 2
         */
        static double Hipotenusa(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
        public void Teorema()
        {
            char cont = 's';
            while (cont == 's')
            {
                Console.WriteLine("Digite o valor do primeiro cateto: ");
                double cateto1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor do segundo cateto: ");
                double cateto2 = Convert.ToDouble(Console.ReadLine());

                // Chama a função para calcular a hipotenusa
                double hipot = Hipotenusa(cateto1, cateto2);
                Console.WriteLine($"O valor da hipotenusa é: {((decimal)hipot)}");

                Console.WriteLine("Deseja realizar outro cálculo? s/n");
                cont = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}




