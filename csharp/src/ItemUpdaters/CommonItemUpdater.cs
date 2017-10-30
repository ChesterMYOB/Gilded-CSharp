using System;
using System.Collections.Generic;


namespace csharp.src.ItemUpdaters
{
    class CommonItemUpdater : BaseItemUpdater 
    {
        public CommonItemUpdater(string tag) : base(tag)
        {
        }

        public CommonItemUpdater(List<string> tags) : base(tags)
        {
        }

        public override Item UpdateQuality(Item item)
        {
            if (item.Quality > 0) item.Quality--;
            return item;
        }

        public override Item CheckForNegativeQuality(Item item)
        {
            if (item.SellIn < 0 && item.Quality > 0) item.Quality--;
            return item;
        }
    }
}
