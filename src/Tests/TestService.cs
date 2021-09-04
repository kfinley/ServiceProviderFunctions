using System.Threading.Tasks;

namespace Tests {

  public class TestRequest { }

  public interface ITestService {
    Task TestMethod(TestRequest request);
  }

  public class TestService : ITestService {
    public Task TestMethod(TestRequest request) {
      return Task.CompletedTask;
    }
  }
}
