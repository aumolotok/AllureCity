using AllureTests.Models.Buildings;
using AllureTests.Models.Peoples;
using AllureTests.Models.Streets;
using System.Collections.Generic;
using System.Linq;

namespace AllureTests.Models.City {
    class City {

        public List<Road> Roads = new List<Road> {
            new Boulevard("Lenina",
                    new List<Building> {
                        new House(1,
                            new List<Resident> {
                                new Adult(Profession.Doctor),
                                new Adult(Profession.Saler),
                            }),

                        new House(2, 
                            new List<Resident> {
                                new Adult(Profession.Doctor),
                                new Child(),
                                new Child()
                            }),

                        new House(3,
                            new List<Resident> {
                                new Adult(Profession.Worker),
                                new Adult(Profession.Doctor),
                                new Child()
                            })
                    }),

            new Boulevard("Mira",
                    new List<Building> {
                        new House(1,
                            new List<Resident> {
                                new Adult(Profession.Saler),
                                new Adult(Profession.Worker),
                            }),

                        new BussinessBuilding(2, BussinessType.Office),

                        new House(3,
                            new List<Resident> {
                                new Adult(Profession.Doctor),
                                new Child(),
                            })
                    }),

            new Prospect("Rebel",
                    new List<Building> {
                        new BussinessBuilding(1, BussinessType.Office),
                        new BussinessBuilding(2, BussinessType.WorkShop),
                        new BussinessBuilding(3, BussinessType.Observatory)
                    }),

            new Prospect("Workers",
                    new List<Building> {
                        new BussinessBuilding(1, BussinessType.Office),
                        new BussinessBuilding(2, BussinessType.WorkShop)
                    }),

            new Street("Central",
                    new List<Building> {
                        new House(1,
                            new List<Resident> {
                                new Child(),
                                new Child(),
                            }),

                        new House(2,
                            new List<Resident> {
                                new Adult(Profession.Saler),
                                new Adult(Profession.Saler),
                                new Adult(Profession.Saler)
                            }),
                    }),

            new Street("Border",
                    new List<Building> {
                        new House(1,
                            new List<Resident> {
                                new Adult(Profession.Doctor),
                                new Adult(Profession.Saler)
                            }),

                        new BussinessBuilding(2, BussinessType.Store),
                    })
        };
        
        public City() { }

        public int HowManyCitizens => Roads.Select(i => i.HowManyResidents()).Sum();

        public int HowManyBuildings => Roads.Select(i => i.HowManyBuildings).Sum();

        public int HowManyChildren => Roads.Select(i => i.HowManyChildren()).Sum();
    }
}
