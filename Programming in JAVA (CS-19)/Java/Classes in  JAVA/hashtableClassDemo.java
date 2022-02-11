import java.util.*;

public class hashtableClassDemo {
    public static void main(String[] args) {
        Hashtable<Integer, String> ht = new Hashtable<Integer, String>();
        ht.put(100, "Steave");
        ht.put(101, "Tobby");
        ht.put(102, "Adam");
        ht.put(103, "Mike");
        System.out.println("Before Remove = " + ht);
        ht.remove(102);
        System.out.println("After Remove 102 = " + ht);
        System.out.println(ht.getOrDefault(101, "No Default"));
    }
}
