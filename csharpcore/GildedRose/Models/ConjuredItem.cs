using System;

namespace GildedRoseKata
{
    public class ConjuredItem : ItemWrapper
    {
        public ConjuredItem(Item item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            Quality = Math.Max(0, Quality - 2);
        }
    }
}