namespace ManipulacaoString.Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cidades = File.ReadAllText(@"C:\Users\adewrotor\source\repos\ManipulacaoString\ManipulacaoString.Exercicio06\Dados\Cidades - Cidades.csv");
            string[] cidade = new string[cidades.Length];
            string guardar = "";

            for (int i = 0; i < cidade.Length; i++)
            {
                Console.WriteLine(cidade[i]);
              
                string[] cidadesArray = cidades.Split(',');
                string Nome = cidadesArray[i];
                string Estado = cidadesArray[3];
                cidade[i] = Nome;
                Console.WriteLine(cidade[i]);

            }
        }
    }
}