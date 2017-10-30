namespace csharp.src.ItemUpdaters
{
    internal class VintageItemUpdater : BaseItemUpdater
    {
        public VintageItemUpdater(string tag) : base(tag){}

        public override Item UpdateQuality(Item item)
        {
            if (item.Quality < QualityUpperLimit) item.Quality++;
            return item;
        }

        public override Item CheckForNegativeQuality(Item item)
        {
            if (item.SellIn < 0 && item.Quality < QualityUpperLimit) item.Quality++;
            return item;
        }
    }
}
