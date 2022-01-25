import java.util.Scanner;

public class findBigValue {

    public static void main(String[] args) {

        Scanner get = new Scanner(System.in);
        int a, b, c;
        System.out.print("Enter A = ");
        a = get.nextInt();
        System.out.print("Enter B = ");
        b = get.nextInt();
        System.out.print("Enter C = ");
        c = get.nextInt();
        System.out.println("_______________________");

        if (a == b) {
            if (b == c) {
                System.out.println("All The Numbers Are Same.");
            }
        } else if (c > a) {
            if (c > b) {
                System.out.println("C is Bigger.");
            } else {
                System.out.println("B is Bigger");
            }
        } else {
            if (a > b) {
                System.out.println("A is Bigger.");
            } else {
                System.out.println("B is Bigger.");
            }
        }
    }
}
