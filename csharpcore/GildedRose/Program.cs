using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var items = GetItems();
            
            var itemQualityUpdater = new ItemPrinter(
                new ItemQualityUpdater());

            var app = new GildedRose(
                itemQualityUpdater, 
                items);

            for (var i = 0; i < 31; i++)
            {
                PrintHeader(i);

                app.UpdateQuality();

                PrintFooter();
            }
        }

        private static void PrintHeader(int i)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
        }

        private static void PrintFooter()
        {
            Console.WriteLine("");
        }

        private static List<Item> GetItems()
        {
            var Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
            return Items;
        }
    }
}
