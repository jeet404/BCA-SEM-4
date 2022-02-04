class A {
    final void meth() {
        System.out.println("This is a Final Method");
    }

    public void disp() {
        System.out.println("I am Method.");
    }
}

class B extends A {
    // void meth() {
    //     // Error-Can not be overridden.
    //     System.out.println("Illlegal");
    // }
}

public class finalWithInheritence {
    public static void main(String[] args) {
        B obj = new B();
        obj.disp();
    }
}
