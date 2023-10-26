namespace Inheritance
{
    class Program      //ınterfacelerde inheritance gibi davranırlar 
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer {FirstName = "Engin" }, new Student{FirstName = "Derin "},new Person{FirstName = "Salih "}
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Person2
    {

    }
    class Customer: Person //interface kullanımından farklı olarakta iki tane nesne atayamazsın yani gelip person2 yiyide burada yazamazsın.
        // customer persondan dünyaya gelmiş bir nesne gibi düşünebiliriz. o yüzden customerı person gibi tanımaldığımızdan hiç bi şey yazmamıza gerek kalmaz.
        // fakat kendine ait özellikleride olabilir.
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }

        
}

