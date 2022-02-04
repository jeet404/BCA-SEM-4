abstract class A {
    abstract void callMe();

    void callMeTwo() {
        System.out.println("This is a Method.");
    }
}

class B extends A {
    void callMe() {
        System.out.println("B is implementation of CallMe.");
    }
}

public class AbstractClassDemo {
    public static void main(String[] args) {
        B b1 = new B();
        b1.callMe();
        b1.callMeTwo();
    }
}