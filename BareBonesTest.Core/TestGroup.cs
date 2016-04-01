namespace BareBonesTest.Core {
    using System.Collections.Generic;

    internal class TestGroup : ITestSuiteNode {
        public string Name { get; }

        public IEnumerable<ITestSuiteNode> Children { get; }
    }
}
