import java.io.*;

public class dataInputStreamDemo {
    public static void main(String[] args) throws Exception {
        InputStream input = new DataInputStream("C:\\check\\test.txt");
        DataInputStream inst = new DataInputStream(input);
        int count = input.available();
        byte[] ary = new byte[count];
        for (byte bt : ary) {
            char k = (char) bt;
            System.out.println(k + "-");
        }
    }
}
