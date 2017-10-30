namespace csharp.src.ItemUpdaters
{
    public class ConjuredItemUpdater : BaseItemUpdater
    {
        public ConjuredItemUpdater(string tag) : base(tag){}

        public override Item UpdateQuality(Item item)
        {
            if (item.Quality > QualityLowerLimit) item.Quality--;
            if (item.Quality > QualityLowerLimit) item.Quality--;
            return item;
        }

        public override Item CheckForNegativeQuality(Item item)
        {
            if (item.SellIn < 0 && item.Quality > QualityLowerLimit) item.Quality--;
            if (item.SellIn < 0 && item.Quality > QualityLowerLimit) item.Quality--;
            return item;
        }
    }
}