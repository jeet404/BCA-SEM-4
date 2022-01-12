import java.util.*;

public class userInputDemo {

    public static void main(String[] args) {
        Scanner get = new Scanner(System.in);
        System.out.print("Enter a String : ");
        String str = get.nextLine();
        System.out.println("You have entered : " + str);
    }

}