import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

class BorderExp extends JFrame {
    BorderExp() {
        JPanel pa = new JPanel();
        pa.setLayout(new BorderLayout());
        pa.add(new Button("Welcome"), BorderLayout.NORTH);
        pa.add(new Button("KSC"), BorderLayout.SOUTH);
        pa.add(new Button("Layout"), BorderLayout.EAST);
        pa.add(new Button("Border"), BorderLayout.WEST);
        pa.add(new Button("KSCPAC"), BorderLayout.CENTER);
        add(pa);
        setSize(300, 300);
        setVisible(true);
    }
}

public class BorderLayoutDemo {
    public static void main(String[] args) {
        new BorderExp();
    }
}
