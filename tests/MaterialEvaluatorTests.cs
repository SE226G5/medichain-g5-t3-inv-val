using System;
using Xunit;         
using MaterialApp;   

namespace MaterialApp.Tests
{
    public class MaterialEvaluatorTests
    {
        [Fact]
        public void Test_Expired()
        {
            var evaluator = new MaterialEvaluator();
            var result = evaluator.ValidateMaterialExpiry(DateTime.Today.AddDays(-2), 5);
            Assert.Equal("Expired", result);
        }

        [Fact]
        public void Test_NearExpiry()
        {
            var evaluator = new MaterialEvaluator();
            var result = evaluator.ValidateMaterialExpiry(DateTime.Today.AddDays(2), 5);
            Assert.Equal("Near Expiry", result);
        }

        [Fact]
        public void Test_Valid()
        {
            var evaluator = new MaterialEvaluator();
            var result = evaluator.ValidateMaterialExpiry(DateTime.Today.AddDays(10), 5);
            Assert.Equal("Valid", result);
        }
    }
}
