using System;

namespace GildedRoseKata
{
    public class BackstagePassItem : ItemWrapper
    {
        public BackstagePassItem(Item item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            Quality = CalculateQuality();
        }

        private int CalculateQuality()
        {
            return SellIn switch
            {
                _ when SellIn <= 0 => 0,
                _ when SellIn <= 5 => Math.Min(50, Quality + 3),
                _ when SellIn <= 10 => Math.Min(50, Quality + 2),
                _ => Math.Min(50, Quality + 1),
            };
        }
    }
}