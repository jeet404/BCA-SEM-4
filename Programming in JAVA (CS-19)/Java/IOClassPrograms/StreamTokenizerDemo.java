import java.io.IOException;
import java.io.Reader;
import java.io.StreamTokenizer;
import java.io.StringReader;

public class StreamTokenizerDemo {

    public static void main(String[] args) throws IOException {
        Reader reader = new StringReader("This is a test string for JCG Stream  Tokenizer Example");
        StreamTokenizer tokenizer = new StreamTokenizer(reader);
        while (tokenizer.nextToken() != StreamTokenizer.TT_EOF) {
            System.out.println(tokenizer.sval);
        }

    }
}
