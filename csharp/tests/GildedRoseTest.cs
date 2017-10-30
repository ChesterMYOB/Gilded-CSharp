using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    [TestFixture]
    public class GildedRoseShould
    {
        [Test]
        public void CompleteASimpleFooTest()
        {
            var foo = new Item {Name = "foo", SellIn = 0, Quality = 0};
            var items = new List<Item> { foo };
            var app = new GildedRose(items);
            app.UpdateItems();
            Assert.AreEqual(foo.ToPrettyItem(), items[0].ToPrettyItem());
        }

        [TestCase(Tag.Sulfuras, 0, 0, 0, 0)]
        [TestCase(Tag.Sulfuras, 1, 0, 1, 0)]
        [TestCase(Tag.Sulfuras, 0, 1, 0, 1)]
        [TestCase(Tag.Sulfuras, 1, 1, 1, 1)]
        [TestCase(Tag.Sulfuras, -1, 0, -1, 0)]
        [TestCase(Tag.Sulfuras, -1, 1, -1, 1)]
        [TestCase(Tag.Sulfuras, -1, 2, -1, 2)]
        [TestCase(Tag.Sulfuras, -100, 100, -100, 100)]
        public void ReturnAnUpdatedLegendaryItem(string name, int sellIn, int quality, int expectedSellIn, int expectedQuality)
        {
            var legendardItem = new Item { Name = name, SellIn = sellIn, Quality = quality };
            var legendardItems = new List<Item> { legendardItem };

            var expectedItem = new Item { Name = name, SellIn = expectedSellIn, Quality = expectedQuality };
            var expectedItems = new List<Item> { expectedItem };

            var app = new GildedRose(legendardItems);
            var updatedItems = app.UpdateItems();
            Assert.AreEqual(expectedItems[0].ToPrettyItem(), updatedItems[0].ToPrettyItem());
        }

        [TestCase(Tag.CommonItem, 0, 0, -1, 0)]
        [TestCase(Tag.CommonItem, 1, 0, 0, 0)]
        [TestCase(Tag.CommonItem, 0, 1, -1, 0)]
        [TestCase(Tag.CommonItem, 1, 1, 0, 0)]
        [TestCase(Tag.CommonItem, -1, 0, -2, 0)]
        [TestCase(Tag.CommonItem, -1, 1, -2, 0)]
        [TestCase(Tag.CommonItem, -1, 2, -2, 0)]
        public void ReturnAnUpdatedCommonItem(string name, int sellIn, int quality, int expectedSellIn, int expectedQuality)
        {
            var commonItem = new Item { Name = name, SellIn = sellIn, Quality = quality };
            var commonItems = new List<Item> { commonItem };

            var expectedItem = new Item { Name = name, SellIn = expectedSellIn, Quality = expectedQuality };
            var expectedItems = new List<Item> { expectedItem };

            var app = new GildedRose(commonItems);
            var updatedItems = app.UpdateItems();

            Assert.AreEqual(expectedItems[0].ToPrettyItem(), updatedItems[0].ToPrettyItem());
        }

        [TestCase(Tag.AgedBrie, 0, 0, -1, 2)]
        [TestCase(Tag.AgedBrie, 1, 0, 0, 1)]
        [TestCase(Tag.AgedBrie, 0, 1, -1, 3)]
        [TestCase(Tag.AgedBrie, 1, 1, 0, 2)]
        [TestCase(Tag.AgedBrie, -1, 0, -2, 2)]
        [TestCase(Tag.AgedBrie, -1, 1, -2, 3)]
        [TestCase(Tag.AgedBrie, -1, 2, -2, 4)]
        [TestCase(Tag.AgedBrie, -5, 50, -6, 50)]
        public void ReturnAnUpdatedAgedItem(string name, int sellIn, int quality, int expectedSellIn, int expectedQuality)
        {
            var agedItem = new Item { Name = name, SellIn = sellIn, Quality = quality };
            var agedItems = new List<Item> { agedItem };

            var expectedItem = new Item { Name = name, SellIn = expectedSellIn, Quality = expectedQuality };
            var expectedItems = new List<Item> { expectedItem };

            var app = new GildedRose(agedItems);
            var updatedItems = app.UpdateItems();

            Assert.AreEqual(expectedItems[0].ToPrettyItem(), updatedItems[0].ToPrettyItem());
        }

        [TestCase(Tag.BackstagePass, 0, 0, -1, 0)]
        [TestCase(Tag.BackstagePass, 1, 0, 0, 3)]
        [TestCase(Tag.BackstagePass, 0, 1, -1, 0)]
        [TestCase(Tag.BackstagePass, 1, 1, 0, 4)]
        [TestCase(Tag.BackstagePass, -1, 0, -2, 0)]
        [TestCase(Tag.BackstagePass, -1, 1, -2, 0)]
        [TestCase(Tag.BackstagePass, -1, 2, -2, 0)]
        [TestCase(Tag.BackstagePass, 8, 2, 7, 4)]
        [TestCase(Tag.BackstagePass, 1, 49, 0, 50)]
        public void ReturnAnUpdatedConcertItem(string name, int sellIn, int quality, int expectedSellIn, int expectedQuality)
        {
            var concertItem = new Item { Name = name, SellIn = sellIn, Quality = quality };
            var concertItems = new List<Item> { concertItem };

            var expectedItem = new Item { Name = name, SellIn = expectedSellIn, Quality = expectedQuality };
            var expectedItems = new List<Item> { expectedItem };

            var app = new GildedRose(concertItems);
            var updatedItems = app.UpdateItems();

            Assert.AreEqual(expectedItems[0].ToPrettyItem(), updatedItems[0].ToPrettyItem());
        }

        //[TestCase(Tag.ConjuredCake, 0, 0, -1, 0)]
        //[TestCase(Tag.ConjuredCake, 1, 0, 0, 0)]
        //[TestCase(Tag.ConjuredCake, 0, 1, -1, 0)]
        //[TestCase(Tag.ConjuredCake, 1, 1, 0, 0)]
        //[TestCase(Tag.ConjuredCake, 1, 2, 0, 0)]
        //[TestCase(Tag.ConjuredCake, 1, 3, 0, 1)]
        //[TestCase(Tag.ConjuredCake, -1, 0, -2, 0)]
        //[TestCase(Tag.ConjuredCake, -1, 1, -2, 0)]
        //[TestCase(Tag.ConjuredCake, -1, 2, -2, 0)]
        //[TestCase(Tag.ConjuredCake, -1, 4, -2, 0)]
        //[TestCase(Tag.ConjuredCake, -1, 8, -2, 4)]
        public void ReturnAnUpdatedConjuredItem(string name, int sellIn, int quality, int expectedSellIn, int expectedQuality)
        {
            var conjuredItem = new Item { Name = name, SellIn = sellIn, Quality = quality };
            var conjuredItems = new List<Item> { conjuredItem };

            var expectedItem = new Item { Name = name, SellIn = expectedSellIn, Quality = expectedQuality };
            var expectedItems = new List<Item> { expectedItem };

            var app = new GildedRose(conjuredItems);
            var updatedItems = app.UpdateItems();

            Assert.AreEqual(expectedItems[0].ToPrettyItem(), updatedItems[0].ToPrettyItem());
        }
    }
}
