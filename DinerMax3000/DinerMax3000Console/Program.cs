using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000BusinessLayer;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Item A", "Item A Description", 25.50);
            summerMenu.AddMenuItem("Item B", "Item B Description", 25.50);
            summerMenu.HosptialDirections = "Right around the corner";

            DrinksMenu drinkMenu = new DrinksMenu();
            drinkMenu.Disclaimer = "Don't drink and code";
            drinkMenu.AddMenuItem("Whiskey Coke", "It'll get you hammered", 5);
            drinkMenu.AddMenuItem("Rum and Coke", "It'll get you drunk", 5);

            Order hungryGuestOrder = new Order();
            for (int i = 0; i < summerMenu.items.Count - 1; i++)
            {
                MenuItem currentItem = summerMenu.items[i];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in drinkMenu.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            } 


            Console.WriteLine("The total is: " hungryGuestOrder.Total);
            Console.ReadKey();
        }
    }
}
