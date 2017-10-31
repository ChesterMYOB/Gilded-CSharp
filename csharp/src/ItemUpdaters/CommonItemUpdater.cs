using System.Collections.Generic;

namespace csharp.src.ItemUpdaters
{
    internal class CommonItemUpdater : BaseItemUpdater 
    {
        public override Item UpdateQuality(Item item)
        {
            if (item.Quality > QualityLowerLimit) item.Quality--;
            return item;
        }

        public override Item CheckForNegativeQuality(Item item)
        {
            if (item.SellIn < 0 && item.Quality > QualityLowerLimit) item.Quality--;
            return item;
        }
    }
}
