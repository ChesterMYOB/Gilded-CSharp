using System.Collections.Generic;

namespace csharp.src.ItemUpdaters
{
    public class LegendaryBaseItemUpdater : BaseItemUpdater
    {
        public LegendaryBaseItemUpdater(string tag) : base(tag)
        {
        }
        public LegendaryBaseItemUpdater(List<string> tags) : base(tags)
        {
        }

        public override Item UpdateQuality(Item item)
        {
            return item;
        }

        public override Item CheckForNegativeQuality(Item item)
        {
            return item;
        }

        public override Item DecrementSellIn(Item item)
        {
            return item;
        }
    }
}