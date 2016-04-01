namespace BareBonesTest.Core {
    using System.Threading.Tasks;

    public interface IRunnableTest : ITest {
        Task<ITestRunResult> Start();
    }
}
