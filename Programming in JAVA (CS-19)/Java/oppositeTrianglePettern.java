import java.util.*;

public class oppositeTrianglePettern {

    public static void main(String[] args) {
        int n;
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter How Many Lines Do you have to Print : ");
        n = sc.nextInt();
        for (int i = 0; i <= n - 1; i++) {
            for (int j = 0; j <= i; j++) {
                System.out.print(" ");
            }
            for (int k = 0; k <= n - 1 - i; k++) {
                System.out.print("*" + " ");
            }
            System.out.println();
        }
    }
}
