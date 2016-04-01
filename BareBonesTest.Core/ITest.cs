namespace BareBonesTest.Core {
    using System.Collections.Generic;

    public interface ITest {
        string Name { get; }

        IEnumerable<ITest> SubTests { get; }

        bool AsRunnable(out IRunnableTest runnable);
    }
}
