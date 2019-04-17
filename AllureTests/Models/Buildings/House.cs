using AllureTests.Models.Peoples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllureTests.Models.Buildings {
    class House : Building {
        public List<Resident> Residents { get; private set; }

        public House(int number, List<Resident> residents) : base(isLiving: true, number: number) {
            Residents = residents;
            Residents.ForEach(i => i.House = this);
        }

        public House() { }

        public int HowManyResidents => Residents.Count;
        
        public int HowManyChildren => Residents.Where(i => i.IsAdult == false).Select(i => i).Count();
    }
}
