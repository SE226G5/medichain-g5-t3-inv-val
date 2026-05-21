public class TestDecision {

    public static String decideTestAction(boolean materialAvailable) {

        if (materialAvailable) {
            return "Proceed";
        } else {
            return "Transfer To Another Lab";
        }
    }
}
