public class MaterialService
‎{
‎    public bool DeductMaterialQuantity(int currentQuantity, int deductQuantity)
‎    {
‎        if (currentQuantity <= 0 || deductQuantity <= 0 || deductQuantity > currentQuantity)
‎        {
‎            return false;
‎        }
‎
‎        currentQuantity -= deductQuantity;
‎
‎        if (currentQuantity == 0)
‎        {
‎            Console.WriteLine("Material Out Of Stock"); 
‎        }
‎
‎        return true;
‎    }
‎}
