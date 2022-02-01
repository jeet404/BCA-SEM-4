class Biggest {
    public Biggest() {
        System.out.println("I am Biggest.");
    }
}

class Bigger extends Biggest {
    public Bigger() {
        System.out.println("I am Bigger.");
    }
}

class Big extends Bigger {
    public Big() {
        System.out.println("I am Big.");
    }
}

public class MultiLvlInheritence {
    public static void main(String[] args) {
        Big b = new Big();
    }
}
