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
            if (item.Name != Tag.AgedBrie && item.Name != Tag.BackstagePass)
            {
                if (item.Quality > 0 && item.Name != Tag.Sulfuras)
                {
                    item.Quality = item.Quality - 1;

                }
            }
            else
            {
                if (item.Quality < 50)
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
            }

            if (item.Name != Tag.Sulfuras)
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
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
            return item;
        }
    }
}
