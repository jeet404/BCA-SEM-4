public class ExceptionHandlingDemo {
    public static void main(String[] args) {
        try {
            int j = 5 / 0;
            System.out.println("Exception Demo");
        } catch (ArithmeticException e) {
            System.out.println(e);
        }
        System.out.println("Rest of All Code.");
    }
}
