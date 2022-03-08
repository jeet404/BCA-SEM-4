import java.io.*;

public class readingStringDemo {
    public static void main(String[] args) {
        try {
            String text;
            InputStreamReader isr = new InputStreamReader(System.in);
            BufferedReader br = new BufferedReader(isr);
            text = br.readLine();
            System.out.println(text);
        } catch (Exception e) {

        }
    }
}
