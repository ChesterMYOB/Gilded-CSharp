using System;
using System.Collections.Generic;
using csharp.src;
using csharp.src.ItemUpdaters;
using NUnit.Framework;

namespace csharp
{
    public class GildedRose
    {
        private readonly IList<Item> _items;

        public GildedRose(IList<Item> items)
        {
            _items = items;  
        }

        public IList<Item> UpdateItems()
        {
            foreach (var item in _items)
            {
                foreach (var itemUpdater in UpdaterFactory.GetUpdaters(item))
                {
                    itemUpdater.UpdateItem(item);
                }
            }
            return _items;
        }
    }
}
