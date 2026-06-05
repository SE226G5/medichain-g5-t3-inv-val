public class TestFeasibilityValidator {

    public static String validateTestFeasibility(int availableQuantity, int requiredQuantity, boolean expired, boolean alternativeLabAvailable) {

        if (availableQuantity <= 0) {
            if (alternativeLabAvailable) {
                return "Transfer to another lab";
            } else {
                return "Postpone test";
            }
        } else if (availableQuantity < requiredQuantity) {
            if (alternativeLabAvailable) {
                return "Transfer to another lab";
            } else {
                return "Postpone test";
            }
        } else if (expired) {
            return "Reject test - material expired";
        } else {
            return "Test approved";
        }
    }
}
