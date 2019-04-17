using AllureTests.Models.Buildings;
using System.Collections.Generic;

namespace AllureTests.Models.Streets {
    class Boulevard : Road {
        public Boulevard(string name, List<Building> buildings) : base(name, buildings, hasHighWay: true, hasPark: true) { }
    }
}
