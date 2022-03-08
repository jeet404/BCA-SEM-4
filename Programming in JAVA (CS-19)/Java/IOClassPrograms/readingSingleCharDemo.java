import java.io.*;

public class readingSingleCharDemo {
    public static void main(String[] args) {
        try {

            BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
            char c = (char) br.read();
            System.out.println(c);
        } catch (Exception e) {

        }
    }
}
