using System;

namespace GildedRoseKata
{
    public abstract class ItemWrapper
    {
        public string Name => _item.Name;

        public int Quality
        {
            get { return _item.Quality; }
            protected set { _item.Quality = value; }
        }

        public int SellIn
        {
            get { return _item.SellIn; }
            protected set { _item.SellIn = value; }
        }

        public void UpdateInventory()
        {
            UpdateQuality();
            UpdateSellin();

            if (SellIn < 0)
            {
                UpdateQuality();
            }
        }

        private readonly Item _item;

        public ItemWrapper(Item item)
        {
            _item = item;
        }

        protected abstract void UpdateQuality();

        protected virtual void UpdateSellin() 
        {
            SellIn -= 1;
        }
    }
}