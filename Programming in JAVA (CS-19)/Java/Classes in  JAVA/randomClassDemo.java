import java.util.Random;
import java.util.RandomAccess;
import java.util.*;

public class randomClassDemo {
    public static void main(String[] args) {
        Random r = new Random();
        System.out.println("A Random Int = " + r.nextInt());
        System.out.println("A Random 0-49 = " + r.nextInt(50));
        System.out.println("A Random Double = " + r.nextDouble());
        System.out.println("A Random Float = " + r.nextFloat());
    }
}