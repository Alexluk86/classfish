﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishClass
{
    class Fish 
    {
        public double price { get; set; }
        public int mass { get; set; }
        public string place { get; set; }
        public string name { get; set; }

        public void GetFishInfo()
        {
            Console.WriteLine($"Имя: {name}| |Масса: {mass}| |Место: {place}|");
        }
    }
   class Dieout : Fish
    {
        public string type { get; set; }
        Categories of protected status { get; set; }
        public virtual void GetFish1Info()
        {
            Console.WriteLine($"Имя: {name}| |Место: {place}| |Тип: {type}");
        }
    }
} 
