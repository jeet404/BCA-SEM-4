class demo {
    public demo() {
        System.out.println("Normal Constructor");
    }
}

class test {
    public test(int i, int j) {
        int k = i + j;
        System.out.println("Sum  = " + k);
    }
}

public class ParameterizedConstructor {
    public static void main(String[] args) {
        demo d = new demo();
        test t = new test(5, 3);
    }
}
