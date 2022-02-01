class base {
    public void show() {
        System.out.println("I am Base Class.");
    }
}

class child extends base {
    public void disp() {
        System.out.println("I am Derived Class.");
    }
}

public class SingleInheritence {
    public static void main(String[] args) {
        child c = new child();
        c.show();
        c.disp();
    }
}
