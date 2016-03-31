namespace BareBonesTest.Core {
    using System.Collections.Generic;
    using System.Threading.Tasks;

    internal class TestCase : ITestable {
        public string Name { get; }

        public IEnumerable<ITestable> SubTests { get; }

        public Task<ITestResult> Run() {
            throw new System.NotImplementedException();
        }
    }
}
