import java.util.*;

public class LinkedListDemo {
    public static void main(String[] args) {
        LinkedList<String> l1 = new LinkedList<String>();

        l1.add("A");
        l1.add("B");
        l1.addLast("C");
        l1.addFirst("D");
        l1.add(2, "E");
        System.out.println(l1);
        l1.remove("B");
        l1.remove(3);
        l1.removeFirst();
        l1.removeLast();
        System.out.println(l1);
    }
}