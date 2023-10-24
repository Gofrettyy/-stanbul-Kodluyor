namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var Return = Add2(20, 30);
            //int number1 = 20;
            //int number2 = 100;
            //var Result = Add3(ref number1, number2);
            //Console.WriteLine(Result);
            //Console.WriteLine(number1);
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine(Add4(1, 2, 3, 4, 5, 6, 7));
            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added");
        }
        // Methodları genel anlamda biz Don't Repeat Yourself! prensibi için yaparız.

        static int Add2(int number1, int number2 = 30) //Buradaki = 30 number 2 ye yukarıda bir değer verilmezse number 2 için 30 değeri kullanılır.
        {
            return number1 + number2;


        }
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;

        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;                                                             //Aynı methodu farklı parametrelerle kullanmaya Method Overloading denir. yandaki örnek  Method Overloading'e bir örnektir.
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
    }
    static int Add4 (params int[] numbers)                                    // birden fazla parametreli method kullanmak ama Method overloading yapmak bizi yoracaksa onun yerine params kullanarak istediğimiz sonucu elde edebiliriz.
    {
        numbers.Sum();
    }
}
    // void git bir yere bi şey yaz bir kayıt yap demek
    //number1 ilk örnekte değer tip olduğu için değeri methodun içinde değiştirdiğimizde method dışındaki number1 değerini etkilemeyecektir.
    // Referans tipler gibi bir yerde değerini değiştirdiğimizde her yerde değişmesini işstersen Ref keywordu kullanarak değişkenin davranış biçimini yani tipini değiştirebiliriz.
    // refin bir alternatifi de outtur. aynı şekilde kullanılır. fakat outta method dışındada number1a bir değer atamalıydın ama outta atamasanda olur.