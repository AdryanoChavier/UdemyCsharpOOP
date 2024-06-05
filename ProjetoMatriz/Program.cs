namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double[,] mat = new double[2,3];
           
           
           Console.WriteLine("Quantos elementos a matri tem no total: "+mat.Length);
           Console.WriteLine("Quantidade de linhas: "+mat.Rank);
           Console.WriteLine("Primeira dimensão tem quantos elementos: "+ mat.GetLength(0));
           Console.WriteLine("Segunda dimensão tem quantos elementos: "+ mat.GetLength(1));


        }
    }
}