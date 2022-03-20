import java.awt.*;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class GridLayoutDemo extends JFrame {
    GridLayoutDemo() {
        JPanel p1 = new JPanel();
        p1.setLayout(new GridLayout(4, 2));
        FlowLayout layout = new FlowLayout();
        JPanel p2 = new JPanel();
        p2.setLayout(layout);
        JLabel one, two, three, four;
        JTextField tname, tcode, tsalary, tdesig;
        JButton btnSave, btnExit;
        one = new JLabel("Name");
        tname = new JTextField(20);
        two = new JLabel("Code");
        tcode = new JTextField(20);
        three = new JLabel("Designation");
        tdesig = new JTextField(20);
        four = new JLabel("Salary");
        tsalary = new JTextField(20);
        btnSave = new JButton("Save");
        btnExit = new JButton("Exit");
        p1.add(one);
        p1.add(tname);
        p1.add(two);
        p1.add(tcode);
        p1.add(three);
        p1.add(tdesig);
        p1.add(four);
        p1.add(tsalary);
        p2.add(btnSave);
        p2.add(btnExit);
        add(p1, "North");
        add(p2, "East");
        setVisible(true);
        this.setSize(400, 180);
    }

    public static void main(String[] args) {
        new GridLayoutDemo();
    }
}
