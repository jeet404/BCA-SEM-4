class test {
    test() {
        System.out.println("I am Constructor.");
    }

    public void disp() {
        System.out.println("I am Method.");
    }
}

public class ContructorDemo {

    public static void main(String[] args) {
        test t = new test();
        t.disp();
    }
}