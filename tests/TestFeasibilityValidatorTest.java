public class TestFeasibilityValidatorTest {

    public static void main(String[] args) {

        String test1 =
                TestFeasibilityValidator.validateTestFeasibility(
                        0, 5, false, true);

        String test2 =
                TestFeasibilityValidator.validateTestFeasibility(
                        0, 5, false, false);

        String test3 =
                TestFeasibilityValidator.validateTestFeasibility(
                        10, 5, true, false);

        String test4 =
                TestFeasibilityValidator.validateTestFeasibility(
                        10, 5, false, false);

        System.out.println("Test 1: " + test1);
        System.out.println("Test 2: " + test2);
        System.out.println("Test 3: " + test3);
        System.out.println("Test 4: " + test4);
    }
}
