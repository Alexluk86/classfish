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
            Console.WriteLine($"Имя: {name}| |Возраст: {mass}| |Место: {place}|");
        }
    }

