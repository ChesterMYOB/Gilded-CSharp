using System;
using System.Collections.Generic;


namespace csharp.src.ItemUpdaters
{
    class CommonItemUpdater : BaseItemUpdater 
    {
        public CommonItemUpdater(string tag) : base(tag)
        {
        }

        public CommonItemUpdater(List<string> tags) : base(tags)
        {
        }



        public override Item UpdateQuality(Item item)
        {
            throw new NotImplementedException();
        }

        public override Item UpdateSellIn(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
