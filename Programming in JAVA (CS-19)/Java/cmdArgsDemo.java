public class cmdArgsDemo {

    public static void main(String[] args) {

        int temp = 0;
        for (int i = 0; i < args.length; i++) {
            System.out.println(args[i]);
            temp = 1;
        }
        if (temp == 0) {
            System.out.println("No Argument Passed!!!");
        }
    }

}