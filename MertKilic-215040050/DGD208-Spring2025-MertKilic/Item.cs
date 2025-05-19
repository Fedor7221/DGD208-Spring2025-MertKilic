using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGD208_Spring2025_MertKilic
{
    public class Item
    {
        public ItemType type;
        public int effect;
        public int duration;

        public Item(ItemType type, int effect, int duration)
        {
            this.type = type;
            this.effect = effect;
            this.duration = duration;
        }
    }
}