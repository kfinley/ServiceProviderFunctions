using System;
using System.Threading.Tasks;

using Xunit;
using FluentAssertions;

namespace Tests {
  public class ServiceProviderFunctionsTest {

    [Fact]
    public void Register_service_run_method() {

      // Arrange
      var testFunction = new TestFunction();

      // Act
      var task = testFunction.Handler(new TestRequest());

      // Assert
      Task.WhenAll(task);
      task.Status.Should().Be(TaskStatus.RanToCompletion);
    }
  }
}
