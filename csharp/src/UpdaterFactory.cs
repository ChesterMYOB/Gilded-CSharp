using System.Collections.Generic;
using csharp.src;
using csharp.src.ItemComponents;
using csharp.src.ItemUpdaters;

namespace csharp
{
    public class UpdaterFactory
    {
        public static Dictionary<string, IList<BaseItemUpdater>> ItemUpdaterDictionary = new Dictionary<string, IList<BaseItemUpdater>>
        {
            {Tag.CommonItem, new List<BaseItemUpdater> {new CommonItemUpdater()}},
            {"+5 Dexterity Vest", new List<BaseItemUpdater> {new CommonItemUpdater()}},
            {"Elixir of the Mongoose", new List<BaseItemUpdater> {new CommonItemUpdater()}},
            {Tag.ConjuredCake, new List<BaseItemUpdater> {new ConjuredItemUpdater()}},
            {Tag.BackstagePass, new List<BaseItemUpdater> {new LimitedItemUpdater()}},
            {Tag.AgedBrie, new List<BaseItemUpdater> {new VintageItemUpdater()}},
            {Tag.Sulfuras, new List<BaseItemUpdater> {new LegendaryBaseItemUpdater()}}
        };

        public static IList<BaseItemUpdater> GetUpdaters(Item item)
        {
            return GetUpdaters(item.Name);
        }

        public static IList<BaseItemUpdater> GetUpdaters(string itemName)
        {
            if(!ItemUpdaterDictionary.ContainsKey(itemName)) throw new KeyNotFoundException(itemName + " is not registered!");
            return ItemUpdaterDictionary[itemName];          
        }
    }
}
