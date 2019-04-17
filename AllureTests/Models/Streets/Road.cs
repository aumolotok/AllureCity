using AllureTests.Models.Buildings;
using AllureTests.Models.Peoples;
using System.Collections.Generic;
using System.Linq;

namespace AllureTests.Models.Streets {
    class Road {

        public string Name { get; private set; }

        public bool HasHightWay { get; private set; }

        public bool HasPark { get; private set; }

        public List<Building> Buildings { get; private set; }

        public Road(string name, List<Building> buildings, bool hasHighWay, bool hasPark) {
            Name = name;
            Buildings = buildings;
            HasHightWay = hasHighWay;
            HasPark = hasPark;
            Buildings.ForEach(i => i.Road = this);
        }


        public int HowManyBuildings => Buildings.Count;

        public int HowManyResidents() {
            if(!Buildings.Any(i => i.IsLiving == true)) {
                return 0;
            }

            var houses = Buildings.Where(i => i is House).Select(i => i as House).ToList();
            return houses.Select(i => i.HowManyResidents).Sum();
        }

        public int HowManyChildren() {
            if (!Buildings.Any(i => i.IsLiving == true)) {
                return 0;
            }

            var houses = Buildings.Where(i => i is House).Select(i => i as House).ToList();
            return houses.Select(i => i.HowManyChildren).Sum();
        }

        //private List<Resident> GetResidents() {
        //    if (!Buildings.Any(i => i.IsLiving == true)) {
        //        return null;
        //    }

        //    return Buildings.Where(i => i is House).Select(i => i as House).Select(i => i.Residents).ToList();
        //}

        public bool DoesStreetHasObservatory() {
            throw new KeyNotFoundException("");
        }
    }
}
