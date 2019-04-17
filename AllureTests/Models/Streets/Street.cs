using AllureTests.Models.Buildings;
using System.Collections.Generic;

namespace AllureTests.Models.Streets {
    class Street : Road {
        public Street(string name, List<Building> buildings) : base(name, buildings, hasHighWay: false, hasPark: true) { }


    }
}
