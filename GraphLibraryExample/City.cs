using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLibraryExample
{
    class City : IComparable
    {
        public string name { get; }
        public int year { get; }

        public City(string n, int y)
        {
            name = n;
            year = y;
        }
        public override string ToString()
        {
            return name + ", " + year;
        }


        public int CompareTo(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                return -1;
            City city = (City)obj;
            return (name == city.name && year == city.year) ? 0 : 1;

        }

        private static City[] cities = new City[]
        {
            new City("Москва", 1147), new City("Санкт-Петербург", 1703),
            new City("Новосибирск", 1893), new City("Екатеринбург", 1723),
            new City("Нижний Новгород", 1221), new City("Казань", 1005),
            new City("Самара", 1586), new City("Омск", 1716),
            new City("Челябинск", 1736), new City("Ростов-на-Дону", 1749),
            new City("Уфа", 1574), new City("Волгоград", 1589),
            new City("Пермь", 1723), new City("Красноярск", 1628),
            new City("Воронеж", 1586), new City("Саратов", 1590),
            new City("Краснодар", 1793), new City("Тольятти", 1737),
            new City("Барнаул", 1730), new City("Ижевск", 1760)
        };

        public static City RandomCity()
        {
            int n = cities.Length;
            Random rnd = new Random();
            return cities[rnd.Next() % n];
        }
       
    }
}
