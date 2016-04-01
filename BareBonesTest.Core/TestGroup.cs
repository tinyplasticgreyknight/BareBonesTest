namespace BareBonesTest.Core {
    using System.Collections.Generic;

    internal class TestGroup : ITest {
        public string Name { get; }

        public IEnumerable<ITest> SubTests { get; }

        public bool AsRunnable(out IRunnableTest runnable) {
            runnable = null;
            return false;
        }
    }
}
