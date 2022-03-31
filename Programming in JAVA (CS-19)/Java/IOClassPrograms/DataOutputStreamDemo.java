import java.io.*;

public class DataOutputStreamDemo {
    public static void main(String[] args) throws IOException {  
          FileOutputStream file = new FileOutputStream("C:\\check\\testout.txt");  
          DataOutputStream data = new DataOutputStream(file);  
          data.writeInt(65);  
          data.flush();  
          data.close();  
          System.out.println("Succcess...");  
      }
}
