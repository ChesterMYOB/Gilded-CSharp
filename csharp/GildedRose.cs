using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {


        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                DoSomethingTo(item);
            }
        }

        private static Item DoSomethingTo(Item item)
        {
            if (item.Name == Tag.Sulfuras)
            {
                ProcessSulfurasItem(item);
            }
            else
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

                item.SellIn = item.SellIn - 1;


                if (item.SellIn < 0)
                {
                    ProcessItemsWithNegativeSellIn(item);
                }
            }



            return item;
        }

        private static void ProcessSulfurasItem(Item item)
        {

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
