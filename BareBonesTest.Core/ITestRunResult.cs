namespace BareBonesTest.Core {
    public interface ITestRunResult {
        ITestSuiteNode Subject { get; }

        TestRunStatus Status { get; }
    }
}
