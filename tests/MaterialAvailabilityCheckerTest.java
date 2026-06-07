public class MaterialAvailabilityCheckerTest {

    public static void main(String[] args) {

        String test1 =
                MaterialAvailabilityChecker.checkMaterialAvailability(10, 5);
        System.out.println(test1);

        String test2 =
                MaterialAvailabilityChecker.checkMaterialAvailability(3, 5);
        System.out.println(test2);

        String test3 =
                MaterialAvailabilityChecker.checkMaterialAvailability(0, 5);
        System.out.println(test3);

        String test4 =
                MaterialAvailabilityChecker.checkMaterialAvailability(10, 0);
        System.out.println(test4);
    }
}
