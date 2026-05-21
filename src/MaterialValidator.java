public class MaterialValidator {

    public static boolean isMaterialValid(int quantity, boolean expired) {

        if (quantity <= 0) {
            return false;
        }

        if (expired) {
            return false;
        }

        return true;
    }
}
