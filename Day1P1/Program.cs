namespace Day1P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook1 = new PhoneBook();

            //int phoneValue = phoneBook1["aa"] = 123;


            //Console.WriteLine($"Value of entered Name = {phoneValue}");

            //PhoneBook phoneBook2 = new PhoneBook();
            string nameValue = phoneBook1[125] = "Nada";
            //Console.WriteLine($"Value of entered Number: {nameValue}");

            var nameLength = phoneBook1.Numbers.Length;
            for(int i = 0;i< nameLength;i++)
            {
                Console.WriteLine($"{phoneBook1.Names[i]},{phoneBook1.Numbers[i]}");
                   
            }
        }
    }
}
