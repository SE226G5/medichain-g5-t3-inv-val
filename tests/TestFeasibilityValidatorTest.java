public class TestFeasibilityValidator {

    public static String validateTestFeasibility(
            int availableQuantity,
            int requiredQuantity,
            boolean expired,
            boolean alternativeLabAvailable) {

        if (expired)
            return "Reject test - material expired";

        boolean unavailable =
                availableQuantity <= 0 ||
                availableQuantity < requiredQuantity;

        if (unavailable)
            return alternativeLabAvailable
                    ? "Transfer to another lab"
                    : "Postpone test";

        return "Test approved";
    }
}
