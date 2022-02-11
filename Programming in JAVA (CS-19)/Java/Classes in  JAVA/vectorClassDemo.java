import java.util.*;

public class vectorClassDemo {
    public static void main(String[] args) {
        int n = 5;
        Vector<Integer> v = new Vector<Integer>(n);
        for (int i = 1; i <= n; i++) {
            v.add(i);
        }
        System.out.println(v);
        v.remove(3);
        System.out.println(v);
        System.out.println("Size = " + v.size());

    }
}