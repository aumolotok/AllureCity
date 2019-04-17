using System;
using System.Collections.Generic;
using System.Linq;
using Allure.Commons;
using Allure.NUnit.Attributes;
using NUnit.Framework;

namespace AllureTests.Tests {
    [TestFixture]
    [AllureEpic("City tests")]
	[AllureSuite("Numbers Checks")]
    [AllureIssue("Go to .Net documentation")]
    [AllureTms("Go to .Net documentation", "#__net")]
	[Parallelizable(ParallelScope.All)]
    class RoadsCheck : BaseCityTests {

        [Test(Description = "Roads Count")]
        [AllureTag("R-1")]
        [AllureSeverity(Allure.Commons.Model.SeverityLevel.Normal)]
        [AllureSubSuite("Roads Count")]
        [AllureFeature("Infrastructure")]
        [AllureStory("Roads")]
        
        public void NumberOfRoads() {
            AllureLifecycle.Instance.RunStep("Get Roads' name list ",() => { });
            int roads = AllureLifecycle.Instance.RunStep<int>("Cointing the road", () => City.Roads.Count );

            AllureLifecycle.Instance.AddAttachment("Roadsa Names",
                AllureLifecycle.AttachFormat.Txt,
                String.Join("\n", City.Roads.Select(i => i.Name).ToArray()));
            AllureLifecycle.Instance.RunStep( "Check roads number",() => {
                AllureLifecycle.Instance.RunStep("UseMap", () => { });
                AllureLifecycle.Instance.RunStep("Assert preparings", () => {
                    AllureLifecycle.Instance.RunStep("Make an Assert", () => {Assert.That(roads, Is.EqualTo(6), "Wrong road countings"); });
                });       
            });   
        }



        [Test]
        [AllureTag("B-1")]
        [AllureSeverity(Allure.Commons.Model.SeverityLevel.Normal)]
        [AllureSubSuite("Buildings Count")]
        [AllureFeature("Infrastructure")]
        [AllureStory("Buildings")]
        [AllureFlaky]
		public void NumberOfBuildings() {
            AllureLifecycle.Instance.RunStep("Get buildings' number", () => { });
            int buildings = AllureLifecycle.Instance.RunStep<int>("Cointing buildings", () => City.HowManyBuildings);

            AllureLifecycle.Instance.RunStep("Check buildings number", () => Assert.That(buildings, Is.EqualTo(16), "Wrong buildings' numbers"));
  
        }

        [Test]
		[AllureTag("B-1")]
        [AllureSeverity(Allure.Commons.Model
	                    .SeverityLevel.Normal)]
        [AllureSubSuite("Is there a plant")]
        [AllureFeature("Infrastructure")]
		[AllureStory("Buildings")]
		public void IsThereAPlunt() {
            Assert.Inconclusive("Inconclusive");
        }

        [Test]
        [AllureTag("B-1")]
        [AllureSeverity(Allure.Commons.Model.SeverityLevel.Normal)]
        [AllureSubSuite("Is there a school")]
        [AllureFeature("Infrastructure")]
        [AllureFeature("Population")]
		[AllureStory("Buildings")]
        [AllureStory("Education")]
		[Ignore("No No No(((")]

        public void IsThereASchool() {
            Assert.Pass();
        }


    }



    [TestFixture]
    [AllureEpic("Society tests")]
    [AllureSuite("Society Checks")]
    [AllureIssue("Go to .Net documentatuon")]
    [AllureTms("Go to .Net documentatuon", "#__net")]
    [Parallelizable(ParallelScope.Fixtures)]

	class Society : BaseCityTests{

        
        public static IEnumerable<TestCaseData> ChildrenSociety() {
            yield return new TestCaseData(5);
            yield return new TestCaseData(10);
            yield return new TestCaseData(15);
        }

        [TestCaseSource(nameof(ChildrenSociety))]
        [AllureSubSuite("Citizens Count")]
        [AllureFeature("Population")]
        [AllureStory("Count Children")]
        public void ChildrenNumbersMoreOrEqualTo(int moreThen) {
            AllureLifecycle.Instance.RunStep("Get children' number", () => { });
            int children = AllureLifecycle.Instance.RunStep<int>("Cointing children", () => City.HowManyBuildings);

            Assert.That(children, Is.AtMost(moreThen), "No, still less");
        }

        [Test]
        [AllureTag("C-1")]
        [AllureSeverity(Allure.Commons.Model.SeverityLevel.Normal)]
        [AllureSubSuite("Citizens Count")]
        [AllureFeature("Population")]
        [AllureStory("Citizens")]
        public void NumberOfCitizens() {

            AllureLifecycle.Instance.RunStep("Get citizens' number", () => { });
            int buildings = AllureLifecycle.Instance.RunStep<int>("Cointing citizens", () => throw new TimeoutException("Timed out"));
        }




    }
        
        
}
