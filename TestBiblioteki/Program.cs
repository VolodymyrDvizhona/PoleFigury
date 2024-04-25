using Biblioteka;
namespace TestBiblioteki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość boku do kwadratu: ");
            double bok =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole kwadratu wynosi {0}.",
                Pole.Kwadrat(bok));

            Console.WriteLine("\nPodaj długość promienia: ");
            double promien =
                Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole koła wynosi {0}. ",
                Pole.Kolo(promien));

            Console.WriteLine("\nKoniec Programu");
            Console.ReadKey();
        }
    }
}
