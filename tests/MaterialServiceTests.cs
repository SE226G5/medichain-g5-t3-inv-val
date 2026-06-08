using Xunit;
using System;
using System.IO;

public class MaterialServiceTests
{
    [Fact]
    public void DeductMaterialQuantity_CurrentQuantityLessThanOrEqualZero_ReturnsFalse()
    {
        var service = new MaterialService();
        bool result = service.DeductMaterialQuantity(0, 5);
        Assert.False(result);
    }

    [Fact]
    public void DeductMaterialQuantity_DeductQuantityLessThanOrEqualZero_ReturnsFalse()
    {
        var service = new MaterialService();
        bool result = service.DeductMaterialQuantity(10, -2);
        Assert.False(result);
    }

    [Fact]
    public void DeductMaterialQuantity_DeductGreaterThanCurrent_ReturnsFalse()
    {
        var service = new MaterialService();
        bool result = service.DeductMaterialQuantity(5, 10);
        Assert.False(result);
    }

    [Fact]
    public void DeductMaterialQuantity_ValidQuantities_ReturnsTrueAndDeducts()
    {
        var service = new MaterialService();
        bool result = service.DeductMaterialQuantity(10, 4);
        Assert.True(result);
    }

    [Fact]
    public void DeductMaterialQuantity_StockBecomesZero_PrintsOutOfStockMessage()
    {
        var service = new MaterialService();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        bool result = service.DeductMaterialQuantity(5, 5);
        string output = stringWriter.ToString().Trim();

        Assert.True(result);
        Assert.Equal("Material Out Of Stock", output);
    }
}
