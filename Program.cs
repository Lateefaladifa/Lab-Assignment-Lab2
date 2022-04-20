using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare 10 variables with then different datatypes
            string MyName = "Abdullateef Adebayo";
            int MyAge = 30;
            float Temperature = 32F;
            double EuroToDollar = 501.56;
            decimal Value = 0.51M;
            long Number = 12000;
            dynamic Amount = 976;
            var MyPage = "Welcome To WellaHealth";

            Console.WriteLine("Hello World!");
            Console.WriteLine(MyName);
            Console.WriteLine(MyAge);
            Console.WriteLine(Temperature);
            Console.WriteLine(EuroToDollar);
            Console.WriteLine(Value);
            Console.WriteLine(Number);
            //Implicit  Conversion
            float x = MyAge;
            long y = MyAge;

            Console.WriteLine(x);
            Console.WriteLine(y);
            //Explicit Conversion
            int EuroToDollarInt = (int)EuroToDollar;

            Console.WriteLine(EuroToDollarInt);
            Console.WriteLine(Amount);
            Console.WriteLine(MyPage);

            

        }
    }
}
