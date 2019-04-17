using Allure.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Newtonsoft.Json.Linq;

namespace AllureTests.TestSamples {
    static class AllureProjExtensions {

        //public static void WrapInStep(this AllureLifecycle lifecycle, Action action, string stepName = "", [CallerMemberName] string callerName = "") {
        //    if (string.IsNullOrEmpty(stepName)) stepName = callerName;

        //    var id = Guid.NewGuid().ToString();
        //    var stepResult = new StepResult { name = stepName };
        //    try {
        //        lifecycle.StartStep(id, stepResult);
        //        action.Invoke();
        //        lifecycle.StopStep(step => stepResult.status = Status.passed);
        //    } catch (Exception e) {
        //        lifecycle.StopStep(step => {
        //            step.statusDetails = new StatusDetails {
        //                message = e.Message,
        //                trace = e.StackTrace
        //            };
        //            step.status = AllureNUnitHelper.GetNUnitStatus();
        //        });
        //        throw;
        //    }
        //}


        //internal static Status GetNUnitStatus() {
        //    var result = TestContext.CurrentContext.Result;

        //    if (result.Outcome.Status != TestStatus.Passed) {
        //        var jo = JObject.Parse(AllureLifecycle.Instance.JsonConfiguration);
        //        var allureSection = jo["allure"];
        //        try {
        //            var config = allureSection?.ToObject<AllureExtendedConfiguration>();
        //            if (config?.BrokenTestData != null)
        //                foreach (var word in config.BrokenTestData)
        //                    if (result.Message.Contains(word))
        //                        return Status.broken;
        //        } catch (Exception) {
        //            //Ignored
        //        }

        //        switch (result.Outcome.Status) {
        //            case TestStatus.Inconclusive:
        //                return Status.broken;
        //            case TestStatus.Skipped:
        //                return Status.skipped;
        //            case TestStatus.Passed:
        //                return Status.passed;
        //            case TestStatus.Warning:
        //                return Status.broken;
        //            case TestStatus.Failed:
        //                return Status.failed;
        //            default:
        //                return Status.none;
        //        }
        //    }

        //    return Status.passed;
        //}
    }
}
