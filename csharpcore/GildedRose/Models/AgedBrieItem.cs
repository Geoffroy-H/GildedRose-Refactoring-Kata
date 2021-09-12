using System;

namespace GildedRoseKata
{
    public class AgedBrieItem : ItemWrapper
    {
        public AgedBrieItem(Item item)
            : base(item)
        {
        }

        protected override void UpdateQuality()
        {
            Quality = Math.Min(50, Quality + 1);
        }
    }
}