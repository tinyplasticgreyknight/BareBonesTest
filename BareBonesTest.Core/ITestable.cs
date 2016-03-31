namespace BareBonesTest.Core {
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ITestable {
        string Name { get; }

        IEnumerable<ITestable> SubTests { get; }

        ITestResult Result { get; }

        Task Run();
    }
}
