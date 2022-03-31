import java.io.FileReader;
import java.io.IOException;
import java.io.StreamTokenizer;

public class StreamTokenizerDemo2 {

    public static void main(String[] args) throws IOException {

        // Read from a file
        FileReader fileReader = new FileReader("C:\\check\\test.txt");
        StreamTokenizer filetokenizer = new StreamTokenizer(fileReader);
        while (filetokenizer.nextToken() != StreamTokenizer.TT_EOF) {
            if (filetokenizer.ttype == StreamTokenizer.TT_NUMBER) {
                System.out.println(filetokenizer.nval);
            } else if (filetokenizer.ttype == StreamTokenizer.TT_WORD) {
                System.out.println(filetokenizer.sval);
            }
        }
    }
}
