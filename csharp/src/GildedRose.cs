using System.Collections.Generic;

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
                UpdateItem(item);
            }
            return Items;
        }

        private static Item UpdateItem(Item item)
        {
            if (item.Name == Tag.Sulfuras) return UpdateLegendaryItem(item);
     
            UpdateItemQuality(item);

            if (item.SellIn < 0) NegativeSellInCalculations(item);

            return item;
        }


        private static Item UpdateLegendaryItem(Item item)
        {
            return item;
        }

        private static void UpdateItemQuality(Item item)
        {
            item.SellIn--;
            if (item.Name == Tag.AgedBrie || item.Name == Tag.BackstagePass)
            {
                item.Quality += IncrementQuality(item);
                if (item.Quality > 50) item.Quality = 50;
                return;
            }
            if (item.Quality > 0) item.Quality--;
        }

        private static int IncrementQuality(Item item)
        {
            if (item.Name != Tag.BackstagePass) return 1;
            if (item.SellIn < 5) return 3;
            return item.SellIn < 10 ? 2 : 1;
        }


        private static void NegativeSellInCalculations(Item item)
        {
            switch (item.Name)
            {
                case Tag.AgedBrie:
                    if (item.Quality < 50) item.Quality++;
                    break;
                case Tag.BackstagePass:
                    item.Quality = 0;
                    break;
                default:
                    if (item.Quality > 0) item.Quality--;
                    break;
            }           
        }
    }
}
