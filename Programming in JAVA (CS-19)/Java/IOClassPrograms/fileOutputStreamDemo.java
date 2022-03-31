import java.io.FileOutputStream;

public class fileOutputStreamDemo {
    public static void main(String args[]) {
        try {
            FileOutputStream fout = new FileOutputStream("C:\\check\\testout.txt");
            // fout.write(65);
            String s="Ram And Bharat.";// byte
            byte b[]=s.getBytes();
            fout.write(b);
            fout.close();
            System.out.println("success...");
        } catch (Exception e) {
            System.out.println(e);
        }
    }
}
