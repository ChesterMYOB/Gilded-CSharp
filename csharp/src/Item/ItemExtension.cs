using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public static class ItemExtension
    {
        public static string ToPrettyItem(this Item item)
        {
            return item.Name + ", " + item.SellIn + ", " + item.Quality;
        }
    }
}
