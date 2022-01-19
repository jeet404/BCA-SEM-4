public class arrayDemo {

    public static void main(String[] args) {
        int month_days[];
        String month_name[];
        month_days = new int[] {
                31, 28, 31,
                30, 31, 30,
                31, 31, 30,
                31, 30, 31
        };
        month_name = new String[] {
                "January", "Fabruary", "March",
                "April", "May", "June",
                "July", "Augast", "Saptember",
                "October", "November", "December"
        };

        for (int i = 0; i < month_name.length; i++) {
            System.out.println(month_name[i] + " has " + month_days[i] + " days.");
        }
    }

}