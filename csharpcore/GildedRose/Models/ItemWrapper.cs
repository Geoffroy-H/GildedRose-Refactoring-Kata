using System;

namespace GildedRoseKata
{
    public abstract class ItemWrapper
    {
        public string Name 
        { 
            get { return _item.Name; }
            protected set { _item.Name = value; }
        }

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

        public abstract void UpdateQuality();

        public virtual void UpdateSellin() 
        {
            SellIn -= 1;
        }
    }
}