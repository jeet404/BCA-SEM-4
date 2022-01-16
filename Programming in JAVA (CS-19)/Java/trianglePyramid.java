import java.util.*;

public class trianglePyramid {
    public static void main(String args[]) {

        int i, j, n;
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter How Many Lines Do you have to Print : ");
        n = sc.nextInt();
        for (i = 0; i < n; i++) {
            for (j = n - i; j > 1; j--) {
                System.out.print(" ");
            }
            for (j = 0; j <= i; j++) {
                System.out.print("* ");
            }
            System.out.println();
        }
    }
}
