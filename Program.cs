using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Fish fish = new fish();
            fish.name = "Сом";
            fish.price = 45;
            fish.age = 30;
            fish.place = "Озеро";

            fish.GetfishInfo();

            Fish1 fish1 = new Fish1();
            fish1.type = "Осетровые";
            fish1.name = "Осетр";
            fish1.place = "Реки";
            fish1.price = 100;
            fish1.mass = 7;


            fish1.GetFish1Info();

            Console.ReadLine();
        }
    }
}
