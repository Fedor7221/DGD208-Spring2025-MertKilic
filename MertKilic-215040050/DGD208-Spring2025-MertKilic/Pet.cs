using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGD208_Spring2025_MertKilic
{
    public class Pet
    {
        public PetType type;
        public int food = 50;
        public int sleep = 50;
        public int smile = 50;
        public bool IsAlive => food > 0 && sleep > 0 && smile > 0;
    }
}