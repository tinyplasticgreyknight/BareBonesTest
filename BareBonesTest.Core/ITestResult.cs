namespace BareBonesTest.Core {
    public interface ITestResult {
        ITestable Subject { get; }

        TestStatus Status { get; }
    }
}
