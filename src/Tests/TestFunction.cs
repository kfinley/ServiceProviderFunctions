using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ServiceProviderFunctions;

namespace Tests {
  public class TestFunction : ServiceProviderFunction {

    protected override void ConfigureServices(IServiceCollection sc, IConfiguration configuration) {
      sc.AddTransient<ITestService, TestService>();
    }

    public async Task Handler(TestRequest @event) {
      await base.Run<ITestService>(service => service.TestMethod(@event));
    }
  }
}
