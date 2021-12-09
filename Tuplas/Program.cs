using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) product = (1, "Stout");

            Console.WriteLine($"{product.id} {product.name}");

            product.name = "Cerveza Porter";

            Console.WriteLine($"{product.id} {product.name}");

            var person = (1, "Vicente", 12.2);

            Console.WriteLine($"Persona {person.Item1}, {person.Item2}, {person.Item3}");

            var people = new[]
            {
                (1, "Vicente"),
                (2, "Mariana"),
                (3, "Zoe")
            };

            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1}, {p.Item2}");
            }

            (int id, string name)[] people2 = new[]
            {
                (1, "Vicente"),
                (2, "Mariana"),
                (3, "Zoe")
            };

            foreach (var p2 in people2)
            {
                Console.WriteLine($"{p2.id}, {p2.name}");
            }

            var cityInfo = getLocationCDMX();
            Console.WriteLine($"lat: {cityInfo.lat}, lng: {cityInfo.lng}, Nombre Ciudad: {cityInfo.nameCity}");

            var (_, lng, _) = getLocationCDMX();

            Console.WriteLine(lng);
        }

        public static (float lat, float lng, string nameCity) getLocationCDMX()
        {
            float lat = 19.12121f;
            float lng = -99.19212f;
            string nameCity = "CDMX";

            return (lat, lng, nameCity);
        }
    }
}
