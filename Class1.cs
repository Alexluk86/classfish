using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishClass
{
    class Водоплавующие 
    {
        public double price { get; set; }
        public int mass { get; set; }
        public string place { get; set; }
        public string name { get; set; }

        public void GetFishInfo()
        {
            Console.WriteLine($"Имя: {name}| |Возраст: {mass}| |Место: {place}|");
        }
    }


    class Fish1 : Водоплавующие
    
    {
        public string type { get; set; }

        public virtual void GetFish1Info()
        {
            Console.WriteLine($"Имя: {name}| |Возраст: {age}| |Место: {place}| |Тип: {type}");
        }
    }
}
