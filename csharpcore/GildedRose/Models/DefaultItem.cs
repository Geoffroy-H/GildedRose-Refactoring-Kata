namespace GildedRoseKata
{
    public class DefaultItem : ItemWrapper
    {
        public DefaultItem(Item item) 
            : base(item)
        {
        }

        protected override void UpdateQuality()
        {
            Quality = Quality > 0
                ? Quality - 1
                : 0;
        }
    }
}