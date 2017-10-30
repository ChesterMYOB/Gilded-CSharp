namespace csharp.src.ItemUpdaters
{
    public class LegendaryBaseItemUpdater : BaseItemUpdater
    {
        public LegendaryBaseItemUpdater(string tag) : base(tag){}
        public override Item UpdateSellIn(Item item)
        {
            return item;
        }
        public override Item UpdateQuality(Item item)
        {
            return item;
        }
        public override Item CheckForNegativeQuality(Item item)
        {
            return item;
        }     
    }
}