class ovrDemo {
    public ovrDemo() {
        System.out.println("No Parameters");
    }

    public ovrDemo(int a, int b) {
        System.out.println("Product = " + (a * b));
    }

    public ovrDemo(int a, int b, int c) {
        System.out.println("Sum = " + (a + b + c));
    }

    public ovrDemo(double a, double b) {
        System.out.println("Substraction = " + (a - b));
    }
}

public class ContructorOverloadingDemo {
    public static void main(String[] args) {
        ovrDemo o1 = new ovrDemo();
        ovrDemo o2 = new ovrDemo(3, 6);
        ovrDemo o3 = new ovrDemo(1, 2, 3);
        ovrDemo o4 = new ovrDemo(2.33, 1.03);
    }
}
