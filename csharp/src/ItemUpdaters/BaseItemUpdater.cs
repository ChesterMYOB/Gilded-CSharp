using System.Collections.Generic;

namespace csharp.src.ItemUpdaters
{
    public abstract class BaseItemUpdater
    {
        public int QualityUpperLimit { get; set; } = 50;
        public int QualityLowerLimit { get; set; } = 0;

        public Item UpdateItem(Item item)
        {
            item = UpdateSellIn(item);
            item = UpdateQuality(item);
            item = CheckForNegativeQuality(item);
            return item;
        }

        public virtual Item UpdateSellIn(Item item)
        {
            item.SellIn--;
            return item;
        }
        public abstract Item UpdateQuality(Item item);
        public abstract Item CheckForNegativeQuality(Item item);
    }
}