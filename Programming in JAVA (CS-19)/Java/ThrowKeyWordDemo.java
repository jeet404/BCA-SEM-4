public class ThrowKeyWordDemo {
    public static void main(String[] args) {
        try {
            int i = 1;
            int j = 2;
            int k = i + j;
            if (k < 10) {
                throw new ArithmeticException();
            }
        } catch (NullPointerException e) {
            System.out.println(e);
        } catch (ArithmeticException e1) {
            System.out.println(e1);
            System.out.println("Using Throw");
        } finally {
            System.out.println("I am Final");
        }
    }
}
