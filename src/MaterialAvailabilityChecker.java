public class MaterialAvailabilityChecker {

    public static String checkMaterialAvailability(
            int availableQuantity,
            int requiredQuantity) {

        if (requiredQuantity <= 0)
            return "Invalid required quantity";

        if (availableQuantity <= 0)
            return "Material not available";

        if (availableQuantity < requiredQuantity)
            return "Insufficient material quantity";

        return "Material is available";
    }
}
