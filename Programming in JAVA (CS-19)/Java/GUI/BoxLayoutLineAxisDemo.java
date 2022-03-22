import java.awt.*;
import javax.swing.*;
import javax.swing.plaf.ComponentInputMapUIResource;

public class BoxLayoutLineAxisDemo extends Frame {
    Button buttons[];

    public BoxLayoutLineAxisDemo() {
        buttons = new Button[5];
        setComponentOrientation(ComponentOrientation.RIGHT_TO_LEFT);
        for (int i = 0; i < buttons.length; i++) {
            buttons[i] = new Button("Button" + (i + 1));
            add(buttons[i]);
        }
        setLayout(new BoxLayout(this, BoxLayout.LINE_AXIS));
        setSize(400, 400);
        setVisible(true);
    }

    public static void main(String[] args) {
        BoxLayoutLineAxisDemo b = new BoxLayoutLineAxisDemo();
    }
}