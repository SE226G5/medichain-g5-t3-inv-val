public class MaterialValidatorTest {

    public static void main(String[] args) {

        boolean result1 =
            MaterialValidator.isMaterialValid(10, false);

        boolean result2 =
            MaterialValidator.isMaterialValid(0, false);

        System.out.println("Valid Material: " + result1);
        System.out.println("Invalid Material: " + result2);
    }
}
