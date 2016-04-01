namespace BareBonesTest.Core {
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    internal class TestCase : IRunnableTest {
        public string Name { get; }

        public IEnumerable<ITest> SubTests {
            get { return Enumerable.Empty<ITest>(); }
        }

        public bool AsRunnable(out IRunnableTest runnable) {
            runnable = this;
            return true;
        }

        public Task<ITestRunResult> Start() {
            throw new System.NotImplementedException();
        }
    }
}
