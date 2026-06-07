public class MaterialAvailabilityChecker {

    public static String checkMaterialAvailability(int availableQuantity, int requiredQuantity) {

        if (availableQuantity <= 0) {
            return "Material not available";
        } else {
            if (requiredQuantity <= 0) {
                return "Invalid required quantity";
            } else {
                if (availableQuantity >= requiredQuantity) {
                    return "Material is available";
                } else {
                    return "Insufficient material quantity";
                }
            }
        }
    }
}
