import java.io.FileInputStream;
import java.io.InputStream;

public class inputStreamDemo {
    public static void main(String[] args) {
        byte[] ary = new byte[100];
        try {
            InputStream input = new FileInputStream("C:\\check\\test.txt");
            System.out.println("Available Bytes in File : " + input.available());
            input.read(ary);
            System.out.println("Data Read From File : ");
            String data = new String(ary);
            System.out.println(data);
            input.close();
        } catch (Exception e) {
            e.getStackTrace();
        }
    }
}
