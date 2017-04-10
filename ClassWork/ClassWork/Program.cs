using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        struct City
        {
           public string Name;
           public  double population;
        }
        static void Main(string[] args)
        {
            string str = "Kharkiv=1431000,Kiev=2804000,Las Vegas=603400";
            string[] city =str.Split(new char[]{',','='});
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            int j = 0;
            City[] City=new City[city.Length/2];
            for (int i = 0; i < city.Length; i+=2)
            {
                City[j].Name = city[i];
                City[j].population = double.Parse(city[i + 1]);
                j++;
            }
            double MaxPopulat = City[0].population;
            int Maxindex = 0;int maxindelenght = 0;
            double maxLenght = City[0].Name.Length;
            for (int i = 1; i < City.Length; i++)
            {
                if (MaxPopulat < City[i].population) { MaxPopulat = City[i].population; Maxindex = i; }
                if(maxLenght<City[i].Name.Length) { maxindelenght = i; }
            }
            Console.WriteLine($" Max population City:{City[Maxindex].Name}");
            Console.WriteLine($"MAx lenght name City:{City[maxindelenght].Name}");
            Console.ReadLine();
        }
    }
}
