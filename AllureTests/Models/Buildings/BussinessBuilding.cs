using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllureTests.Models.Buildings {
    class BussinessBuilding : Building {

        public BussinessType BussinessType;

        public BussinessBuilding(int number, BussinessType bussinessType) : base(isLiving: true, number: number) {
            BussinessType = bussinessType;
        }

        public BussinessBuilding() { }
    }
}
