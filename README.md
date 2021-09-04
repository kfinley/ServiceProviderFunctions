# Service Provider Functions

Service Provider Functions is a small libary (1 class) that takes care of the .net core IServiceCollection dependency injection boilerplate code for AWS Lambda Functions in .net core 3.1.

### How To Use

1. Inherit from the `ServiceProviderFunction` class.
2. Override the `ConfigureServices` method.
3. Execute a method on a service using the Run method.

Example:
```csharp
using Amazon.Lambda.Core;
using ServiceProviderFunctions;

public class TestFunction : ServiceProviderFunction {

  protected override void ConfigureServices(IServiceCollection sc, IConfiguration configuration) {
    sc.AddTransient<ITestService, TestService>();
  }

  public async Task Handler(TestRequest @event) {
    await base.Run<ITestService>(service => service.TestMethod(@event));
  }
}
```
