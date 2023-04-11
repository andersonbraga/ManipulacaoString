namespace ManipulacaoString.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();
            string[] palavras = frase.Split(' ');
            int totalPalavras = palavras.Length;

            Console.WriteLine(totalPalavras);
        }
    }
}