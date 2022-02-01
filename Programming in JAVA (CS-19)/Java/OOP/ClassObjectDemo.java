class test {

    int i = 10;
    int j = 10;

    public void add() {
        System.out.println("Sum = " + (i + j));
    }
}

public class ClassObjectDemo {

    public static void main(String[] args) {
        test t = new test();
        t.add();
    }

}