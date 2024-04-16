namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creiamo un array di cibi preferiti in ordine di preferenza
            string[] foods = { "pizza", "carbonara", "cioccolato", "torta salata", "carne", "sushi", "pistacchio", "pasta e fagioli", "pasta e rape", "pasta e piselli" };

            //stampiamo la lunghezza della classifica
            Console.WriteLine("La lunghezza dell'elenco è: " + foods.Length);

            //stampiamo tutti i cibi preferiti
            for 
                (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("- " + foods[i]);
            }

            //anche il cibo preferito e il cibo meno
            Console.WriteLine($"Il mio cibo preferito è: {foods[0]}");
            Console.WriteLine($"Il mio cibo meno preferito è: {foods[9]}");

            //e i cibi di metà classifica
            Console.WriteLine($"I miei cibi di metà classifica sono: {foods[3]} e {foods[4]}");

        }
    }
}
