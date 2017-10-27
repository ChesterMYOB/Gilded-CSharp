using NUnit.Framework;
using System.Collections.Generic;

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
            app.UpdateQuality();
            Assert.AreEqual(foo.ToPrettyItem(), items[0].ToPrettyItem());
        }

        [TestCase(Tag.Sulfuras, 0, 0)]
        public void ReturnALegendaryItemAsIs(string name, int sellIn, int quality)
        {
            var legendardItem = new Item {Name = name, SellIn = sellIn, Quality = quality};
            IList<Item> items = new List<Item> { legendardItem };
            var app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(legendardItem.ToPrettyItem(), items[0].ToPrettyItem());
        }
    }
}
