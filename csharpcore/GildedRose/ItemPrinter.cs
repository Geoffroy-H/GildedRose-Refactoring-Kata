using System;

namespace GildedRoseKata
{
    public class ItemPrinter : IUpdateItemQuality
    {
        private readonly IUpdateItemQuality _updateItemQuality;

        public ItemPrinter(IUpdateItemQuality updateItemQuality)
        {
            this._updateItemQuality = updateItemQuality;
        }

        public void UpdateItemQuality(Item item)
        {
            Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
            _updateItemQuality.UpdateItemQuality(item);
        }
    }
}