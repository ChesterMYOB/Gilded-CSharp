using System.Collections.Generic;

namespace csharp.src.ItemUpdaters
{
    public abstract class BaseItemUpdater
    {
        public List<string> Tags { get; set; }
        public int QualityUpperLimit { get; set; } = 50;
        public int QualityLowerLimit { get; set; } = 0;

        protected BaseItemUpdater(string tag)
        {
            Tags = new List<string> { tag };
        }
        protected BaseItemUpdater(List<string> tags)
        {
            Tags = tags;
        }
        public Item UpdateItem(Item item)
        {
            if (!Tags.Contains(item.Name)) return item;
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