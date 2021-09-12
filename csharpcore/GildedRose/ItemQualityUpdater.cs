namespace GildedRoseKata
{
    public class ItemQualityUpdater : IUpdateItemQuality
    {
        public void UpdateItemQuality(Item item)
        {
            var wrapper = ItemWrapperFactory.GetItemWrapper(item);
            wrapper.UpdateInventory();
        }
    }
}