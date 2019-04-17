

namespace AllureTests.Models.Peoples {
    class Adult : Resident {

        public Profession Profession { get; private set; }

        public Adult(Profession profession) : base(isdult: true) {
            Profession = profession;
        }

    }
}
