namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 201;

            //if (number == 10) //çift eşittir kullanılır eğer sayı 10 ise diye okuyabiliriz.
            //{
            //    Console.WriteLine("Number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20"); // eğer number 10 olmasaydı ne yapmasını istiyoruz programın else ile yazıyoruz
            //}
            // Yukarıdaki örneği Console.Writeline(number == 10 ? " Number is 10 : "Number is not 10"); şeklindede yazabiliriz.

            //switch (number)
            //{
            //    case 10:
            //        Console.WriteLine("Number is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("number is not 10 or 20");
            //        break;
            //}

           //if (number >=0 && number <= 100)
           // {
           //     Console.WriteLine("Number is Between 0 - 100");
           // }
           //else if(number >=101 && number <=200)
           // {
           //     Console.WriteLine("Number is Between 101- 200");
           // }
           // else if (number > 200 || number < 0)
           // {
           //     Console.WriteLine("Number is Less than 0 and  grater than 200");
           // }

            if (number < 100 )
            {
                if (number >= 90 &&  number <  95) ; 
            }

           // if bloklarıyla yukarıda göründüğü gibi iç içe çalışmakta mümkündür.
            Console.ReadLine();


        }
    }
}