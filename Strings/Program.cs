namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Engin Demiroğ";
            var result = sentence.Length;
            //var result2 = sentece.Clone();

            sentence = "My name is Derin Demiroğ";
            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(""); // bulduğu ilk boşluğu sayar
            var result7 = sentence.LastIndexOf(" "); //boşluğu aramaya sondan başlar
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4); //3. karakterden itibaren 4 tane al
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", " -"); // Boşluk yerine kelimelerin arasına - bıraktık.
            var result13 = sentence.Remove(2,4); //2den itibaren 4.karaktere kadar sil

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        //Intro();
       private  static void Intro()
        {
            string city = "Ankara";
            foreach (var item in city)
            {
                string city2 = " İstanbul";
                Console.WriteLine(String.Format("{0} {1}", city, city2));
                Console.ReadLine();
            }

        }
    }
}

