public class switchCaseStatement {

    public static void main(String[] args) {

        String s = "Car";
        System.out.println("----------------------------");
        switch (s) {
            case "Animal":
                System.out.println("| Hey,This is Animal Section. |");
                break;
            case "Tech":
                System.out.println("| Hey,This is Tech Section. |");
                break;
            case "Car":
                System.out.println("| Hey,This is Car Section. |");
                break;
            default:
                System.out.println(" | None of Section. |");
                break;
        }
        System.out.println("----------------------------");
    }
}
