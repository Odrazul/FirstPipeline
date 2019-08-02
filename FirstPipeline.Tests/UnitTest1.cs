using FirstPipeline.Controllers;
using System;
using Xunit;

namespace FirstPipeline.Tests
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Luis", returnValue.Value);
        }
    }
}
