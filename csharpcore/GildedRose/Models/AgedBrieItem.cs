using System;

namespace GildedRoseKata
{
    public class AgedBrieItem : ItemWrapper
    {
        public AgedBrieItem(Item item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            Quality = Math.Min(50, Quality + 1);
        }
    }
}