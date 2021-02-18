using System;
using System.Collections.Generic;
using System.Text;

namespace WebMoto
{
    public class Motorcycle
    {
        public string Name { get; set; }
        public string ProductionYear { get; set; }
        public string ClassMoto { get; set; }
        public string Price { get; set; }
        public string Info { get; set; }
        public string Characteristic { get; set; }
        public string Plus { get; set; }
        public string Minus { get; set; }
        public Motorcycle(string name, string productionYear, string classMoto, string price, string info, string characteristic, string plus, string minus)
        {
            Name = name;
            ProductionYear = productionYear;
            ClassMoto = classMoto;
            Price = price;
            Info = info;
            Characteristic = characteristic;
            Plus = plus;
            Minus = minus;
        }

        public void ShowData()
        {
            Console.WriteLine("Мотоцикл - " + Name + "\nГода производства " + ProductionYear +
                              "\nКласс - " + ClassMoto + "\nСредняя цена на 2021 год - " + Price);
        }
        public void ShowAllData()
        {
            Console.WriteLine("Мотоцикл - " + Name + "\nГода производства " + ProductionYear +
                              "\nКласс - " + ClassMoto + "\nСредняя цена на 2021 год - " + Price +
                              "\nИнформация: " + Info + "\nКраткие характеристики: " + Characteristic +
                              "\nПлюсы данной модели: " + Characteristic + "\nМинусы данной модели " + Minus);
        }

        //comment
    }
}
