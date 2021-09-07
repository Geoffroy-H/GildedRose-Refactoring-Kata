using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private readonly IList<Item> _items;
        public GildedRose(IList<Item> Items)
        {
            _items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < _items.Count; i++)
            {
                var wrapper = ItemWrapperFactory.GetItemWrapper(_items[i]);
                wrapper.UpdateInventory();
            }
        }
    }
}