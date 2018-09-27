using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int x = 2;
            Console.WriteLine("Number x is " + x);
            x = 5;
            Console.WriteLine("Number x is " + x);

            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8;
            float_num = 5.5f;
            decimal_num = 100.250m;

            Console.WriteLine("Double is " + double_num + " float is " + float_num + "decimal is " + decimal_num);

            string firstName,
            lastName, House;
            firstName = "Jon";
            lastName = "Snow";
            House = "Stark";

            Console.Write("Hello, " + firstName + lastName + " of House " + House);

            bool IsWorking;

            IsWorking = true;

            Console.WriteLine(IsWorking);

            int sum;
            sum = 0;

            int number2;

            // number1 = 5;
            number2 = 100;
            sum = number2;
            Console.WriteLine(sum);

            string FirstName, LastName, House2;

            FirstName = "maddy";
            LastName = "stevens";
            House2 = "Hufflepuff";

            Console.WriteLine("Hello, " + FirstName + " " + LastName);

            //define a bool

            bool isWorking;

            isWorking = false;

            Console.WriteLine(isWorking);
        }
    }
}

//casting and type conversion 
