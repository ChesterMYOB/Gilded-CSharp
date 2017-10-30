using System.Collections.Generic;

namespace csharp.src.ItemUpdaters
{
    public class LimitedItemUpdater : BaseItemUpdater
    {
        public LimitedItemUpdater(string tag) : base(tag)
        {
        }

        public LimitedItemUpdater(List<string> tags) : base(tags)
        {
        }

        public override Item UpdateQuality(Item item)
        {
            item.Quality += IncrementQuality(item);
            if (item.Quality > QualityLimit) item.Quality = 50;
            return item;
        }

        private static int IncrementQuality(Item item)
        {
            if (item.SellIn < 5) return 3;
            return item.SellIn < 10 ? 2 : 1;
        }

        public override Item CheckForNegativeQuality(Item item)
        {
            if (item.SellIn < 0) item.Quality = 0;
            return item;
        }
    }
}