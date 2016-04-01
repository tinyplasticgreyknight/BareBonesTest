namespace BareBonesTest.Core {
    interface ITestCase : ITestSuiteNode {
        string TestBasePath { get; }
    }
}
