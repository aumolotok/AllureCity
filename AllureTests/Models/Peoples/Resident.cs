

using AllureTests.Models.Buildings;

namespace AllureTests.Models.Peoples {
    class Resident {
        public bool IsAdult { get; private set; }

        public Resident(bool isdult) {
            IsAdult = isdult;
        }

        public Resident() { }

        public House House { get; set; } 
    }
}
