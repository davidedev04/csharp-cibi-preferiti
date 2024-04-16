namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] foods = { "pizza", "carbonara", "cioccolato", "torta salata", "carne", "sushi", "pistacchio", "pasta e fagioli", "pasta e rape", "pasta e piselli" };

            Console.WriteLine("La lunghezza dell'elenco è: " + foods.Length);

            for 
                (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("- " + foods[i]);
            }

            Console.WriteLine($"Il mio cibo preferito è: {foods[0]}");
            Console.WriteLine($"Il mio cibo meno preferito è: {foods[9]}");

        }
    }
}
