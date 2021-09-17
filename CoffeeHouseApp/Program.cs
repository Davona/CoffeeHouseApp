using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            tea.name = "BlackTea";
            tea.Create();
            tea.AddWater();
            tea.AddSugar();
            tea.PourInCup();
            Console.WriteLine("-------------");
            Coffee coffee = new Coffee();
            coffee.name = "Cappuccino";
            coffee.Create();
            coffee.AddWater();
            coffee.AddMilk();
            coffee.PourInCup();
            Console.WriteLine("-------------");
            Smoothie smoothie = new Smoothie();
            smoothie.name = "Banane-Strawberry";
            smoothie.Create();
            smoothie.AddWater();
            smoothie.AddSugar();
            smoothie.Mix();
            smoothie.PourInCup();

        }
    }
    class Drinks
    {
        public string name;
        public void AddWater()
        {
            Console.WriteLine("Adding Water");
        }
        public void AddSugar()
        {
            Console.WriteLine("Adding Sugar");
        }
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
    class Tea : Drinks
    {
        public void Create()
        {
            Console.WriteLine($"Adding {name}");
        }
        public void AddLemon()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
    class Coffee : Drinks
    {
        public void Create()
        {
            Console.WriteLine($"Adding {name}");
        }
        public void AddMilk()
        {
            Console.WriteLine("Adding Milk");
        }
    }
    class Smoothie : Drinks
    {
        public void Create()
        {
            Console.WriteLine($"Adding {name}");
        }
        public void Mix()
        {
            Console.WriteLine($"Mixing {name}");
        }
    }
}
