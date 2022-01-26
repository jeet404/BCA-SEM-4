public class cmdArgsCalc {

    public static void main(String[] args) {

        int num1, num2;
        num1 = Integer.parseInt(args[0]);
        num2 = Integer.parseInt(args[2]);

        switch (args[1]) {
            case "+":
                System.out.println(num1 + " " + args[1] + " " + num2 + " =" + (num1 + num2));
                break;
            case "-":
                System.out.println(num1 + " " + args[1] + " " + num2 + " =" + (num1 - num2));
                break;
            case "*":
                System.out.println(num1 + " " + args[1] + " " + num2 + " =" + (num1 * num2));
                break;
            case "/":
                System.out.println(num1 + " " + args[1] + " " + num2 + " =" + (num1 / num2));
                break;
            default:
                System.out.println("You not Entered Right Arguments.");
                break;
        }
    }
}
