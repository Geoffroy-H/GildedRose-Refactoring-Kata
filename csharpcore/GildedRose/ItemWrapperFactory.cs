namespace GildedRoseKata
{
    public static class ItemWrapperFactory
    {
        public static ItemWrapper GetItemWrapper(Item item)
        {
            return item.Name switch
            {
                "Conjured Mana Cake" => new ConjuredItem(item),
                "Aged Brie" => new AgedBrieItem(item),
                "Backstage passes to a TAFKAL80ETC concert" => new BackstagePassItem(item),
                "Sulfuras, Hand of Ragnaros" => new SulfurasItem(item),
                _ => new DefaultItem(item),
            };
        }
    }
}