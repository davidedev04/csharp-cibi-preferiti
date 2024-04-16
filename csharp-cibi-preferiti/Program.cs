namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "pizza", "carbonara", "torta salata", "carne", "sushi" };

            Console.WriteLine("La lunghezza dell'elenco è:" + foods.Length);

            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("- " + foods[i]);
            }
        }
    }
}
