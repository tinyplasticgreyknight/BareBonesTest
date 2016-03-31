namespace BareBonesTest.Core {
    using System.Collections.Generic;
    using System.Threading.Tasks;

    internal class TestCase : ITestable {
        public string Name { get; }

        public IEnumerable<ITestable> SubTests { get; }

        public ITestResult Result { get; }

        public Task Run() {
            throw new System.NotImplementedException();
        }
    }
}
