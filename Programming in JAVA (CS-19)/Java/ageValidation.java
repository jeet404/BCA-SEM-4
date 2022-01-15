import java.util.Scanner;

public class ageValidation {
    public static void main(String[] args) {
        int age;
        Scanner sc = new Scanner(System.in);
        System.out.print("Enter Age : ");
        age = sc.nextInt();
        if (age <= 18) {
            System.out.println("You are not able to get Driving License.");
        } else if (age > 18 && age < 60) {
            System.out.println("You are able to get Driving License.");
        } else if (age >= 60) {
            System.out.println("You are too old to get Driving License, So we can't give you Driving License.");
        }
    }
}
