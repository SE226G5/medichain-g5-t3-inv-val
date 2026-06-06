using System;
using Xunit;
using MaterialApp;

namespace MaterialApp.Tests
{
    public class MaterialEvaluatorTests
    {

        [Fact]
        public void Test_Expired_Case()
        {
            var evaluator = new MaterialEvaluator();
            var result = evaluator.ValidateMaterialExpiry(DateTime.Today.AddDays(-2), 5, false);
            Assert.Equal("Expired", result);
        }

        [Fact]
        public void Test_NearExpiry_NormalMaterial()
        {
            var evaluator = new MaterialEvaluator();
            var result = evaluator.ValidateMaterialExpiry(DateTime.Today.AddDays(2), 5, false);
            Assert.Equal("Near Expiry", result);
        }


        [Fact]
        public void Test_NearExpiry_CriticalMaterial_WithSafetyDays()
        {
            var evaluator = new MaterialEvaluator();

            var result = evaluator.ValidateMaterialExpiry(DateTime.Today.AddDays(7), 5, true);
            Assert.Equal("Near Expiry", result);
        }

        
        [Fact]
        public void Test_Valid_Case()
        {
            var evaluator = new MaterialEvaluator();
            var result = evaluator.ValidateMaterialExpiry(DateTime.Today.AddDays(15), 5, false);
            Assert.Equal("Valid", result);
        }
    }
}
