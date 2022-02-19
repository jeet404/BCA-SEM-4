public class FinallyDemo {
    public static void main(String[] args) {
        try {
            int j = 5 / 2;
            System.out.println("Exception Demo");
        } catch (ArithmeticException e) {
            System.out.println(e);
        } finally {
            System.out.println("Finally Block");
        }
        System.out.println("After Finally");
    }
}
