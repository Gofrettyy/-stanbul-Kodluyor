namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //students[0] = "Engin";
            //students[1] = "Derin"; bunları yazmasakta yukarıdaki gibi yazabiliriz 
            //students[2] = "Salih";

            string[] students2 = new string[] { "Engin" , "Derin" , "Salih" };
            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }
            string[,] regions = new string[5, 3]
            {
                {"","","" },
                 { "","",""},                       // 5 satır 3 kolon olacak şekilde oluşturduk.
                   { "","",""},
                     { "","",""},
                       { "","",""},
            };


            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
// Arrayler gerçek hayatta bir veritabanında yüzlerce kaydımız var bu kayıtları çekip oraya atmak için kullanırız