namespace GildedRoseKata
{
    public class SulfurasItem : ItemWrapper
    {
        public SulfurasItem(Item item)
            : base(item)
        {
            Quality = 80;
        }

        protected override void UpdateQuality()
        {
        }

        protected override void UpdateSellin()
        {
        }
    }
}