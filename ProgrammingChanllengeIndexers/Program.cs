namespace ProgrammingChanllengeIndexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SecretSafe secret = new SecretSafe();

            secret[0] = "first secret in array";
            secret[1] = "second secret in array";
            secret[2] = "third secret in array";

            secret[10] = "secret #10";
            Console.WriteLine($" return first index of array in string: {secret[0]}");
            Console.WriteLine($" return second index of array in string: {secret[1]}");
            Console.WriteLine($" return # index of array in string: {secret[10]}");


          //  secret["secret1"] = 1;

            Console.WriteLine($"index of first value in array is:{secret["secret1"]}");
        }
    }
}
