# Service Provider Functions

Service Provider Functions is a small libary (1 class) that takes care of the boilerplate .net core IServiceCollection dependency injection code for AWS Lambda Functions in .net core 3.1.

### To Use

1. Inherit from the `ServiceProviderFunction` class.
2. Override the `ConfigureServices` method.
3. Execute a method on a service using the Run method.

Example:
```csharp
using ServiceProviderFunctions;

public class Function : ServiceProviderFunction {

  public override void ConfigureServices(IServiceCollection sc, IConfiguration configuration) {
    sc.AddTransient<ISomeService, Service>();
  }

  public async Task Handler(SomeRequest @event, ILambdaContext context) {

    await return base.Run<ISomeService>(service => service.SomeMethod(@event));
  }
}
```
