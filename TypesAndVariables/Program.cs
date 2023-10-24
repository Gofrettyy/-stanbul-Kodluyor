namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 2147483641;
            long number2 = 214547483648;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char character = 'A';
            double number5 = 10.4;
            decimal number6 = 10.4m;
            var number7 = 10;
            number7 = 'A'; //65 olarak gözükecek çünkü artık var ile number 7 ye int bir değer atadık. çift üst virgüller string atamaya çalışsaydık number 7 ye string atayamazdık çünkü number 7 bir int.

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine(days.Friday);
            Console.ReadLine();


        }


    }

    enum days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}



//number1 ise değişkendir 
/*Value Types (Değer Tipleri)  Bütün veri tiplerinin bir sınırı vardır.
 * Interger(int)= Tamsayı sınırı = 2147483647 32 bitlik yer kaplar.
 * long (long) = 62 bitlik yer kaplar intergerın iki katı kadar bellekte yer kaplar. longun sınırı tam 19 karakterden oluşur. -9223372036854775808 ve 9223372036854775807 sınırlarıdır.
 * short (short) = 16 bitlik yer kaplar.
 * byte (byte) = 0 la 255 arası sayıları tutar.
 * boolean (bool)= Genellikle if gibi karşılaştırma bloklarında kullanırız. o yüzden condition kullanırız.
 * char character = integer bir veritipine dönüştürülebilir.
 * double = ondalıklı sayıları ifade ederken kullanılır fakat integer gibi bir değerde atayabilirsin. fakat double bir değeri integera yalın haliyle atayamayız tip dönüşümü gerekir.Virgülden sonra 15 16 değer tutabilir.
 * decimal =integer için long ne ise double içinde decimal odur diyebiliriz. Hassiyet gösteren işlemler için kullanabilir. virgülden sonra 28 29 değer tutar.10.4m ile yazarken sadece 10 yazdığımızda m eklememize gerek yok.
 * Enum = En temel amaç matching string denilen değerler tutmak yerine bir enum sabiti vasıtasıyla çoklu string değerleri string ile yazıp bir daha bir daha yazmaktansa 
 * tek bir parantezde bütün örnekleri görmemizi sağlayan değer tipidir.Karşılaştırma yapacağımız zaman kullanılır.
 * var keyword değişken değildir fakat değişken tutmak için kullanılır.
 */