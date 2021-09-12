using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private readonly IUpdateItemQuality _itemQualityUpdater;
        private readonly IList<Item> _items;

        public GildedRose(
            IUpdateItemQuality itemQualityUpdater,
            IList<Item> Items)
        {
            _itemQualityUpdater = itemQualityUpdater;
            _items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < _items.Count; i++)
            {
                _itemQualityUpdater.UpdateItemQuality(_items[i]);
            }
        }
    }
}