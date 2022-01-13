import java.util.Scanner;

public class userInputDemo2 {
    public static void main(String[] args) {
        int firstNum;
        int secondNum;
        int thirdNum;
        int totalOfNums;

        Scanner sc = new Scanner(System.in);
        System.out.print("Enter Value for First No = ");
        firstNum = sc.nextInt();
        System.out.print("Enter Value for Second No = ");
        secondNum = sc.nextInt();
        System.out.print("Enter Value for Third No = ");
        thirdNum = sc.nextInt();
        totalOfNums = firstNum + secondNum + thirdNum;
        System.out.println("Total = " + totalOfNums);
    }
}
