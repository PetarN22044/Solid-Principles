using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID
{
    public class SuperMarket : ISuperMarket 
    {
        public List<int> ItemIds { get; set; }

        public int CheckMeatFridgeTemperature()
        {
            // Makes request to meat temperature system and the system returns 10
            return 10;
        }
        public bool CheckStock(int itemId)
        {
            return ItemIds.Exists(x => x == itemId);
        }

        public void SellBeverages()
        {
            Console.WriteLine("Beverage is sold!");
        }
        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }
        public void SellMeat()
        {
            Console.WriteLine("Meat is sold!");
        }
        public void SellMiscelenious()
        {
            Console.WriteLine("Miscelenious thing is sold!");
        }
        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }
    public class GreenMarket : IGreenMarket
    {
        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }
    }
    public interface ISuperMarket
    {
        void SellBeverages();
        void SellMeat();
        void SellVegetables();
        void SellFruits();
        void SellMiscelenious();
        bool CheckStock(int itemId);
        int CheckMeatFridgeTemperature();
    }
    public interface IGreenMarket
    {
        void SellVegetables();
        void SellFruits();
    }

}
