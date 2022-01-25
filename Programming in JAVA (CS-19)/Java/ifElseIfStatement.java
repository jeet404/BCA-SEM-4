public class ifElseIfStatement {

    public static void main(String[] args) {

        int i = 5;
        if (i < 3) {
            System.out.println("I am Smaller Then 3.");
        } else if (i == 0) {
            System.out.println("I am Equals to 0.");
        } else if (i >= 3 && i <= 10) {
            System.out.println("I am Greater Then 10.");
        } else {
            System.out.println("None.");
        }
    }
}
