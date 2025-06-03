using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGD208_Spring2025_MertKilic
{
    public static class ItemDatabase
{
    public static List<Item> items= new List<Item>
    {
        new Item("food",ItemType. Food, 15, 2),
        new Item("toy", ItemType.Toy, 15, 1),
        new Item("sleep", ItemType.Sleep, 15 , 3)
    };
}
}
