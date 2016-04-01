namespace BareBonesTest.Core {
    using System.Collections.Generic;
    using System.Linq;

    internal class TestCase : ITestCase {
        public string Name { get; }

        public IEnumerable<ITestSuiteNode> Children {
            get { return Enumerable.Empty<ITestSuiteNode>(); }
        }

        public string TestBasePath { get; }
    }
}
