using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        public IList<Item> Items { get; set; }

        public GildedRose(IList<Item> items)
        {
            Items = items;
        }

        public IList<Item> UpdateItems()
        {
            foreach (var item in Items)
            {
                UpdateItem(item);
            }
            return Items;
        }

        private static Item UpdateItem(Item item)
        {
            if (item.Name == Tag.Sulfuras) return UpdateLegendaryItem(item);

            UpdateItemQuality(item);

            item.SellIn--;

            if (item.SellIn < 0) ProcessItemsWithNegativeSellIn(item);





            return item;
        }

        private static void UpdateItemQuality(Item item)
        {
            if (item.Name != Tag.AgedBrie && item.Name != Tag.BackstagePass)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    ProcessItemWithUnder50Quality(item);
                }
            }
        }

        private static Item UpdateLegendaryItem(Item item)
        {
            return item;
        }

        private static void ProcessItemWithUnder50Quality(Item item)
        {
            item.Quality = item.Quality + 1;

            if (item.Name == Tag.BackstagePass)
            {
                if (item.SellIn < 11 && item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }

                if (item.SellIn < 6 && item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }

        private static void ProcessItemsWithNegativeSellIn(Item item)
        {
            if (item.Name != Tag.AgedBrie)
            {
                if (item.Name != Tag.BackstagePass)
                {
                    if (item.Quality > 0 && item.Name != Tag.Sulfuras)
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
                else
                {
                    item.Quality = item.Quality - item.Quality;
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}
