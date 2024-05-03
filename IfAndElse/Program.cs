namespace Töö
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            
            Console.WriteLine("Mis on sinu nimi?");

            string name = Console.ReadLine();
            if (name != null)
            {
                Console.WriteLine("Sisestasid enda nime:");
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("ei sisestanud enda nime");
            }
        }
    }
}
