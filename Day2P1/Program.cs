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
            Lion lion1 = new Lion("lion1");
            Sparrow sparrow1 = new Sparrow("sparrow1");

            Cage<Lion> lion = new Cage<Lion>();
            Cage<Sparrow> sparrow = new Cage<Sparrow>();

            lion.animals.Add(lion1);
            sparrow.animals.Add(sparrow1);

          
       
            
        }
    }
}
