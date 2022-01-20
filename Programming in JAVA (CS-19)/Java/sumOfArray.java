import java.util.Scanner;

public class sumOfArray {

    public static void main(String[] args) {

        Scanner get = new Scanner(System.in);

        int arr1[][] = new int[2][2];
        int arr2[][] = new int[2][2];
        int arrsum[][] = new int[2][2];

        System.out.println("Enter Values");
        System.out.println("----------------");
        System.out.println("| Metrix-1 |");
        System.out.println("----------------");
        for (int i = 0; i < arr1.length; i++) {
            for (int j = 0; j < arr1[i].length; j++) {
                System.out.print("arr1[" + i + "][" + j + "] = ");
                arr1[i][j] = get.nextInt();
            }
        }
        System.out.println("----------------");
        System.out.println("| Metrix-2 |");
        System.out.println("----------------");
        for (int i = 0; i < arr2.length; i++) {
            for (int j = 0; j < arr2[i].length; j++) {
                System.out.print("arr2[" + i + "][" + j + "] = ");
                arr2[i][j] = get.nextInt();
            }
        }
        for (int i = 0; i < arr1.length; i++) {
            for (int j = 0; j < arr1.length; j++) {
                arrsum[i][j] = arr1[i][j] + arr2[i][j];
            }
        }
        System.out.println("----------------");
        System.out.println("| Sum-Metrix |");
        System.out.println("----------------");
        for (int i = 0; i < arrsum.length; i++) {
            for (int j = 0; j < arrsum.length; j++) {
                System.out.print(arrsum[i][j]+" ");
            }
            System.out.println();
        }
    }
}
