namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(); //classı kullanabilmek için böyle örnek oluştururuz.
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager = new ProductManager(); //classı kullanabilmek için böyle örnek oluştururuz.
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";  //burada bir classın propertysini eşitlediğiniz zaman aslında set etmiş oluyorsunuz yani classlarda yazdığımız set çalışmış oluyor.
            customer.LastName = "Demiroğ";
            Customer customer2 = new Customer
            {
                Id = 2, City= "İstanbul", FirstName = "Derin", LastName="Demiroğ"

            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();


        }
    }
    class CustomerManager    // Bir class oluştururken kelimelerin ilk harfleri büyük oluşturulur. sonrasında örneği oluşturulduktan sonra camel case e geri dönülür.
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }
    class ProductManager {  
        public void Add()
        {
            Console.WriteLine("Product Added");
        }
        public void Update()
        {
            Console.WriteLine("Product  Updated");
        }
    }
}

// OOP'nin en temel unsurudur. 