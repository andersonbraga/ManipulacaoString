namespace ManipulacaoString.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase ");

            string frase = Console.ReadLine().ToUpper();

            Console.Write("Digite quantidade para pular: ");

            int indice = Convert.ToInt32(Console.ReadLine());

            int numero = 0;

            int soma = 0;

            string resultado = "";

            int guardarindice = 0;

            for (int i = 0; i < frase.Length; i++)
            {

                numero = Convert.ToInt16(frase[i] + indice);

                if (numero < 91)
                {
                    resultado += Convert.ToChar(numero);

                    guardarindice++;
                }
                else if (numero >= 90)
                {
                    indice -= guardarindice;

                    numero = numero - 26;

                    resultado += Convert.ToChar(numero);
                }
            }

            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}