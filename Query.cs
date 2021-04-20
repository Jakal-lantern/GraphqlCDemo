using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    public class Query
    {
        public Character GetCharacter() =>
           new Character
           {
               Name = "Jak",
               Age = 15,
               OrbCount = 845,
               CellCount = 76
           };
    }
}
