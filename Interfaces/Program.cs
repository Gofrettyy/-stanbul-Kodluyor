namespace Interfaces
{
    class Program
    {
        static void Main(string[] args) // Amaç temel nesne oluşturup bütün nesneleri ondan implemente etmektir. İnterfaceler servis implamentasyonu yaparken veya katmanlar arası geçiş yaparken kullanırız.
        {
            //InterfacesIntro();        // Bir interface hiçbir zaman newlenemez. kendi başına newlemek mümkün değildir.Soyut nesneler n
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]  // interfaceler gerçekten gerçek hayatta bu şekilde kullanılıyor. Böyle Arrayli kullanımın avantajı yeni bir veri tabanı eklediğimizde kolaylıkla desteklenebiliyor olması.
            {
            new SqlServerCustomerDal(),
            new OracleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer());
            manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });
            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Department = "Computer Sciences"
            };
            manager.Add(student);
        }

        interface IPerson  // SOYUT NESNELER tek başına hiç bir anlam ifade etmez 
        {
            int Id { get; set;  }       // sen bu özellikleri tanımladıysan bu özellikleri implemente eden classlardada yazmak zorundasın.
            string FirstName{ get; set; }
            string LastName { get; set; }
        }
        class Customer: IPerson  // SOMUT NESNELER
        {
           public int Id { get; set; }     
           public  string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address{ get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department{ get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
