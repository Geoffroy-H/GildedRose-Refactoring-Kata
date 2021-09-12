﻿using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            var Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new GildedRose(new ItemQualityUpdater(), Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }
    }
}
