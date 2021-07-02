

namespace LoanChainOfResponsibility.Tests.Handlers
{

    using LoanChainOfResponsibility.Handlers;
    using LoanChainOfResponsibility.Handlers.Models;
    using Xunit;

    public partial class OnTimeHandlerTests
    {
        [Fact]
        public void Given_OnTimeNotTrue_When_CallHandle_ShouldReturnDefaultHandler()
        {
            // Arrange
            Loan loan = new()
            {
                OnTime = false
            };
            var valueExpected = "NOT ON TIME";
            // Act 
            var result = this.systemUnderTest.Handle(loan);

            //Assert
            Assert.Equal(result, valueExpected);
        }
    }
}
