namespace csharp.src.ItemComponents
{
    public static class ItemExtension
    {
        public static string ToPrettyItem(this Item item)
        {
            return item.Name + ", " + item.SellIn + ", " + item.Quality;
        }
    }
}
