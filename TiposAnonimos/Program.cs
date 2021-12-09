using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var vicente = new
            {
                Name = "Vicente",
                Country = "México"
            };

            Console.WriteLine($"{vicente.Name} de {vicente.Country}");

            var people = new[]
            {
                new {Name = "Red", Brand = "Delirium"},
                new {Name = "London Porter", Brand = "Fullers"}
            };

            foreach (var berr in people)
            {
                Console.WriteLine($"Cerveza {berr.Name} {berr.Brand}");
            }
        }
    }
}
