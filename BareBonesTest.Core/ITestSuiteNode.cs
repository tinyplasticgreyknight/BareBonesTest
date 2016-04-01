namespace BareBonesTest.Core {
    using System.Collections.Generic;

    public interface ITestSuiteNode {
        string Name { get; }

        IEnumerable<ITestSuiteNode> Children { get; }
    }
}
