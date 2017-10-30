namespace csharp.src.ItemUpdaters
{
    public class LimitedItemUpdater : BaseItemUpdater
    {
        public LimitedItemUpdater(string tag) : base(tag){}

        public override Item UpdateQuality(Item item)
        {
            item.Quality += IncrementQuality(item.SellIn);
            if (item.Quality > QualityUpperLimit) item.Quality = QualityUpperLimit;
            return item;
        }

        private static int IncrementQuality(int sellIn)
        {
            if (sellIn < 5) return 3;
            if (sellIn < 10) return 2;
            return 1;
        }

        public override Item CheckForNegativeQuality(Item item)
        {
            if (item.SellIn < 0) item.Quality = QualityLowerLimit;
            return item;
        }
    }
}