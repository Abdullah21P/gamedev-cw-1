//Abdullah Saad M1-123

using System;
namespace CW_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String characterName = "Becca";
            String superPower1 = "run it";
            String superPower2 = "cry it";
            int age = 28;
            double speed = 4.1;

            Console.WriteLine("My name is {0} and my super powers are {1} and {2}" +
                ". Im {3} years old and my speed is {4}", characterName, superPower1, superPower2, age, speed);
            String heroName = "Teemo";
            double heroHeight = 1.3;
            int heroAge = 9;
            String heroSuperPower1 = "invis";
            String heroSuperPower2 = "shroms";
            int ageDifference = age - heroAge;
            Console.WriteLine("age difference is {0}", ageDifference);
            if (superPower1 == heroSuperPower1 || superPower1 == heroSuperPower2 || superPower2 == heroSuperPower2)
            {
                Console.WriteLine("they have the same ult");
            }
            else
                Console.WriteLine("they dont have the same ult");

        }
    }
}
