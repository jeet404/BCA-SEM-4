import java.awt.*;
import java.awt.event.*;
import javax.print.FlavorException;
import javax.swing.Action;

class CardDemos extends Frame implements ActionListener {
    CardLayout card = new CardLayout(20, 20);

    CardDemos() {
        setLayout(card);
        Button btnf = new Button("First");
        Button btns = new Button("Second");
        Button btnt = new Button("Third");
        add(btnf, "card1");
        add(btns, "card2");
        add(btnt, "card3");
        btnf.addActionListener(this);
        btns.addActionListener(this);
        btnt.addActionListener(this);
    }

    public void actionPerformed(ActionEvent e) {
        card.next(this);
    }
}

public class CardLayoutDemo {
    public static void main(String[] args) {
        CardDemos frame = new CardDemos();
        frame.setTitle("CardLayout Example");
        frame.setSize(220, 150);
        frame.setResizable(false);
        frame.setVisible(true);
    }
}
