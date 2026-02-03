using System.Threading.Channels;

namespace Day2P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cage<Lion> lionCage = new Cage<Lion>();

            Cage<Animal> animal2 = new Cage<Animal>();
            Animal animal = new Animal();
            animal.Age = 10;
            animal2.Arrive(animal);
        //    Console.WriteLine($"animal age:{animal2.Arrive(animal)}");
            
        }
    }
}
