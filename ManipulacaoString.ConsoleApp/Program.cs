using System.Globalization;

namespace ManipulacaoString.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();
            var fraseTitlleCase = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine(fraseTitlleCase.ToTitleCase(frase));
        }
    }
}