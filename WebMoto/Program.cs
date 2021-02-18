using System;
using System.Collections.Generic;
using System.Text;
using WebMoto;

namespace Website
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase();
            bool menuOperating = true;
            while (menuOperating)
            {
                Console.Write(
                    "Меню: 1)Вывод всех мотоциклов \n2) Поиск мотоцикла \n3) Выход из программы\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        dataBase.Show();
                        break;
                    case "2":
                        string userImput = Console.ReadLine();
                        var motos = dataBase.FindByName(userImput);
                        foreach (var moto in motos)
                        {
                            moto.ShowAllData();
                        }
                        break;
                    case "3":

                        menuOperating = false;
                        break;
                }
            }
        }

        class DataBase
        {
            List<Motorcycle> motorcycles = new List<Motorcycle>()
            {
                new Motorcycle("Минск с4 250", "2011-2016", "Стрит", "1000-1300$", "Если вы хотите получить надежный мотоцикл, на котором можно гонять \n каждый день и по городским туннелям, и по длинным автострадам – Minsk C4 250 отлично подойдет для вас. \nНадежный в управлении, благодаря 5-ступенчатой трансмиссии и легкому для вождения рулю, этот мотобайк станет вашим верным спутником в любых путешествиях. \nНовая современная фара, расположенная в голове мотоцикла, отлично сочетается со стильным дизайном и способствует хорошей видимости и в ночное время суток. Передние и задний тормозные диски позволяют надежно фиксировать движение мотоцикла, что дает уверенность даже начинающему водителю.", "Объем двигателя: 250 см3. \nМощность: 19 л.с. при 8000 об/мин ( 13.9745 кВт). \nМаксимальная скорость: 110 км/ч. \nГлавная передача: Цепь \nКол-во цилиндров: 1\nЧисло тактов: 4\nТип впуска: Карбюратор", " \n Недорогой\nНадежнее многих китайцев\n Внешний вид\n Расход топлива", "\n Беда с запчастями\nБеда с расходниками\n мощности маловато\n"),
                new Motorcycle("Минск Х250", "2017-нынешнее время", "Эндуро", "1100-1400$", "", "2", "3", "4\n"),
                new Motorcycle("Honda CBR f4i","2001-2006", "Cпорт", "3500-5000$", "", "", "", ""),
                new Motorcycle("Honda GOLD WING ","2005-2021", "Турист", "10000-25000$", "", "", "", ""),
            };
            public List<Motorcycle> FindByName(string name)
            {
                return motorcycles.FindAll(x => x.Name.Contains(name));
            }
            public void Show()
            {
                motorcycles.ForEach(x => x.ShowData());
                Console.WriteLine(motorcycles);
            }
            //public void ShowAllData()
            //{
            //    motorcycles.ForEach(x => x.ShowAllData());
            //    Console.WriteLine(motorcycles);
            //}
        }
    }
}