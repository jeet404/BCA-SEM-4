import java.io.FileInputStream;

public class fileInputStreamDemo {
    public static void main(String[] args) {
        try {
            FileInputStream fin = new FileInputStream("C:\\check\\test.txt");
            int i = fin.read();
            System.out.println((char) i);
            fin.close();
        } catch (Exception e) {
            System.out.println(e);
        }
    }
}
