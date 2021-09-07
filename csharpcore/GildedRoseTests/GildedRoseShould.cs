using FluentAssertions;
using GildedRoseKata;
using System.Collections.Generic;
using Xunit;

namespace GildedRoseTests
{
    public class GildedRoseShould
    {
        [Fact]
        public void DecreaseQualityTwiceAsFastWhenSellinIsLessThanZero()
        {
            var items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20},
            };

            var sut = new GildedRose(items);

            sut.UpdateQuality();

            _ = items[0].Quality.Should().Be(18);
        }

        [Theory]
        [InlineData(3, 6, 4)]
        [InlineData(0, 6, 2)]
        [InlineData(0, 0, 0)]
        public void DecreaseQualityTwiceAsFastWhenItemIsConjured(int sellin, int quality, int expectedQuality)
        {
            var items = new List<Item>
            {
                new Item {Name = "Conjured Mana Cake", SellIn = sellin, Quality = quality},
            };

            var sut = new GildedRose(items);

            sut.UpdateQuality();

            _ = items[0].Quality.Should().Be(expectedQuality);
        }

        [Theory]
        [InlineData("+5 Dexterity Vest", 10)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", -2)]
        public void NotDecreaseQualityWhenQualityIsEqualToZero(string itemName, int sellin)
        {
            var items = new List<Item>
            {
                new Item {Name = itemName, SellIn = sellin, Quality = 0},
            };

            var sut = new GildedRose(items);

            sut.UpdateQuality();

            _ = items[0].Quality.Should().Be(0);
        }

        [Fact]
        public void IncreaseAgedBrieQuality()
        {
            var items = new List<Item>
            {
                new Item {Name = "Aged Brie", SellIn = 10, Quality = 0},
            };

            var sut = new GildedRose(items);

            sut.UpdateQuality();

            _ = items[0].Quality.Should().Be(1);
        }

        [Theory]
        [InlineData("Aged Brie")]
        [InlineData("Backstage passes to a TAFKAL80ETC concert")]
        public void NotIncreaseQualityWhenQualityIsEqualToFifty(string itemName)
        {
            var items = new List<Item>
            {
                new Item {Name = itemName, SellIn = 10, Quality = 50},
            };

            var sut = new GildedRose(items);

            sut.UpdateQuality();

            _ = items[0].Quality.Should().Be(50);
        }


        [Fact]
        public void NotDecreaseSulfurasQuality()
        {
            var items = new List<Item>
            {
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 80},
            };

            var sut = new GildedRose(items);

            sut.UpdateQuality();

            _ = items[0].Quality.Should().Be(80);
        }

        [Theory]
        [InlineData(11, 10, 11)]
        [InlineData(10, 10, 12)]
        [InlineData(5, 10, 13)]
        [InlineData(1, 10, 13)]
        [InlineData(0, 10, 0)]
        public void IncreaseBackstagePassesQuality(int sellin, int quality, int expectedQuality)
        {
            var items = new List<Item>
            {
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellin, Quality = quality},
            };

            var sut = new GildedRose(items);

            sut.UpdateQuality();

            _ = items[0].Quality.Should().Be(expectedQuality);
        }
    }
}