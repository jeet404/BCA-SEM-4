import java.util.*;

public class numPattern {

    public static void main(String args[]) {
        int i, j, num, n;
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter How Many Lines Do you have to Print : ");
        n = sc.nextInt();
        for (i = 0; i < n; i++) {
            num = 1;
            for (j = 0; j <= i; j++) {
                System.out.print(num + " ");
                num++;
            }
            System.out.println();
        }
    }
}
