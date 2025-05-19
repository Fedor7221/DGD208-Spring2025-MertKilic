using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGD208_Spring2025_MertKilic
{
    public static class ItemDatabase
{
    public static List<Item> items = new List<Item>
    {
        new Item(ItemType.Food, 20, 2),
        new Item(ItemType.Toy, 15, 1),
        new Item(ItemType.Sleep, 25, 3)
    };
}
}