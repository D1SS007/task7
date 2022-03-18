using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {            
            int goldToCrystalCourse = 10;           

            Console.WriteLine("Введите количество золота: ");

            int amountOfGold = Convert.ToInt32(Console.ReadLine());           

            Console.WriteLine("Курс 1 кристал за "   + goldToCrystalCourse + " золота, сколько кристалов купить?");

            int crystalToBuy = Convert.ToInt32(Console.ReadLine());          

            amountOfGold = amountOfGold - goldToCrystalCourse * crystalToBuy;

            Console.WriteLine("Осталось золота: " + amountOfGold + ", осталось кристалов: " + crystalToBuy);            
        }
    }
}
