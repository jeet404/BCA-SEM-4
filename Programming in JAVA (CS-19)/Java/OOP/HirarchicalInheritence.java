class base {
    int a = 10;
    int b = 5;
}

class add extends base {
    public int plus() {
        return (a + b);
    }
}

class product extends add {
    public int cross() {
        return (a * b);
    }
}

public class HirarchicalInheritence {
    public static void main(String[] args) {
        base obj = new base();
        add a = new add();
        product p = new product();
        int resP = a.plus();
        int resC = p.cross();
        System.out.println(resP);
        System.out.println(resC);
    }
}
