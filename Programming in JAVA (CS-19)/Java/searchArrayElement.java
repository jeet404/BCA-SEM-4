import java.util.Scanner;

public class searchArrayElement {

    public static void main(String[] args) {

        Scanner get = new Scanner(System.in);
        int data[] = new int[10];
        int search;
        int position = 0;
        int temp = 0;
        System.out.println("Enter Value");
        System.out.println("_________________");
        for (int i = 0; i < data.length; i++) {
            System.out.print("data[" + i + "] = ");
            data[i] = get.nextInt();
        }
        System.out.println("_________________");
        System.out.print("Find : ");
        search = get.nextInt();
        for (int i = 0; i < data.length; i++) {
            if (data[i] == search) {
                temp = 1;
                break;
            }
            position = i;
        }
        if (temp == 1) {
            System.out.println("Your value " + search + " Exsist at Position " + (position + 1));
        } else {
            System.out.println("Your Value " + search + " not Exist!");
        }

    }
}
