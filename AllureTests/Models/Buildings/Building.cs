using AllureTests.Models.Streets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllureTests.Models.Buildings {
    class Building {
        public int Area { get; set; }

        public bool IsLiving { get; private set; }

        public int Number { get; private set; }

        public Road Road { get; set; } 

        public Building(bool isLiving, int number) {
            IsLiving = isLiving;
            Number = number;
        }

        public Building() { }
    }
}
