import java.awt.*;
import javax.swing.*;

public class BoxLayoutDemo extends Frame {
    Button buttons[];

    public BoxLayoutDemo() {
        buttons = new Button[5];
        for (int i = 0; i < buttons.length; i++) {
            buttons[i] = new Button("Button" + (i + 1));
            add(buttons[i]);
        }
        setLayout(new BoxLayout(this, BoxLayout.Y_AXIS));
        setSize(400, 400);
        setVisible(true);
    }

    public static void main(String[] args) {
        BoxLayoutDemo b = new BoxLayoutDemo();
    }
}