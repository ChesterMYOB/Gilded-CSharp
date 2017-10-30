using System.Collections.Generic;


namespace csharp.src.ItemUpdaters
{
    public abstract class BaseItemUpdater
    {
        public List<string> Tags { get; set; }

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
            var updatedSellInItem = DecrementSellIn(item);
            var updatedQualityItem = UpdateQuality(updatedSellInItem);
            return CheckForNegativeQuality(updatedQualityItem);
        }

        public virtual Item DecrementSellIn(Item item)
        {
            item.SellIn--;
            return item;
        }
        public abstract Item UpdateQuality(Item item);
        public abstract Item CheckForNegativeQuality(Item updatedQualityItem);
    }
}