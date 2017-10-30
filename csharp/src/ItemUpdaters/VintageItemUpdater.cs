using System.Collections.Generic;

namespace csharp.src.ItemUpdaters
{
    internal class VintageItemUpdater : BaseItemUpdater
    {
        public int QualityLimit { get; set; } = 50;

        public VintageItemUpdater(string tag) : base(tag)
        {
        }

        public VintageItemUpdater(List<string> tags) : base(tags)
        {
        }

        public override Item UpdateQuality(Item item)
        {
            if (item.Quality < QualityLimit) item.Quality++;
            return item;
        }

        public override Item CheckForNegativeQuality(Item item)
        {
            if (item.SellIn < 0 && item.Quality < QualityLimit) item.Quality++;
            return item;
        }
    }
}
