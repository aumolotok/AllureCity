using Allure.Commons;
using Allure.NUnit.Attributes;
using AllureTests.Models.City;
using NUnit.Framework;

namespace AllureTests.Tests {
    [AllureNUnit]
    internal class BaseCityTests : AllureReport {
        public City City;

        [OneTimeSetUp]
        public void SetUp() {
            AllureLifecycle.Instance.RunStep("Tearn on system", () => { });
            AllureLifecycle.Instance.RunStep("Download Data", () => { });
            AllureLifecycle.Instance.RunStep("Build City Model", () => { City = new City(); });
        }
    }
}
