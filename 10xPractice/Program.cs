using Classes;

namespace _10xPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel.ServiceRate = 0.12m;

            PersonModel newPerson = new PersonModel()
            {
                Name = "Azizbek",
                Age = 18,
                CardNumber = "9860 0421 7843 8921"
            };

            Console.WriteLine(newPerson.CardType);
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.Age);
            Console.WriteLine(newPerson.CardNumber);
            Console.WriteLine(PersonModel.Provider);
            Console.WriteLine(PersonModel.ServiceRate) ;

            Console.ReadKey();
        }
    }
}