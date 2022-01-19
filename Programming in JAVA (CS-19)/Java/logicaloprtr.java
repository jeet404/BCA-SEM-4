public class logicaloprtr {

    public static void main(String[] args) {

        int a = 15;
        int b = 30;
        int c = 15;
        int d = 30;

        if (a == c && b == d) {
            System.out.println("Equal");
        } else if (a < b || a < c) {
            System.out.println("A is Smaller than any other values.");
        } else if (a != b) {
            System.out.println("The value of A and B are not equal");
        }
    }
}
