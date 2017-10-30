using System.Collections.Generic;
using csharp.src;
using csharp.src.ItemComponents;
using csharp.src.ItemUpdaters;

namespace csharp
{
    public class GildedRose
    {
        public IList<Item> Items { get; set; }
        public List<BaseItemUpdater> ItemUpdaters { get; set; }

        public GildedRose(IList<Item> items)
        {
            Items = items;
            ItemUpdaters = new List<BaseItemUpdater>
            {
                new CommonItemUpdater( new List<string>
                {
                    Tag.CommonItem,
                    "+5 Dexterity Vest",
                    "Elixir of the Mongoose"
                }),
                new ConjuredItemUpdater(Tag.ConjuredCake),
                new LimitedItemUpdater(Tag.BackstagePass),
                new VintageItemUpdater(Tag.AgedBrie),
                new LegendaryBaseItemUpdater(Tag.Sulfuras)
            };
        }

        public IList<Item> UpdateItems()
        {
            foreach (var item in Items)
            {
                foreach (var itemUpdater in ItemUpdaters)
                {
                    itemUpdater.UpdateItem(item);
                }
            }
            return Items;
        }
    }
}
