using AllureTests.Models.Buildings;
using System.Collections.Generic;

namespace AllureTests.Models.Streets {
    class Prospect : Road {
        public Prospect(string name, List<Building> buildings) : base(name, buildings, hasHighWay: true, hasPark: false) { }
    }
}
