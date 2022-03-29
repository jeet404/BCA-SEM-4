import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class SwingComponentDemo {
    SwingComponentDemo() {
        JFrame f = new JFrame("Swing Component Demo");
        JButton b = new JButton("Click Here");
        b.setBounds(10, 10, 100, 40);
        f.add(b);

        JLabel txtlbl = new JLabel("This is Label");
        txtlbl.setBounds(10, 15, 100, 40);
        f.add(txtlbl);

        JTextField txtbox = new JTextField(20);
        txtbox.setBounds(10, 80, 100, 40);
        f.add(txtbox);

        JTextArea txtarea = new JTextArea("The TextArea..", 4, 20);
        txtarea.setBounds(10, 130, 100, 60);
        f.add(txtarea);

        JPasswordField txtpass = new JPasswordField(15);
        // char[] pwdval = txtpass.getPassword();
        txtpass.setBounds(10, 200, 100, 40);
        f.add(txtpass);

        JCheckBox chk = new JCheckBox("Show Help", true);
        chk.setBounds(10, 240, 100, 40);
        f.add(chk);

        ButtonGroup rg = new ButtonGroup();
        JRadioButton rb1 = new JRadioButton("Easy", true);
        JRadioButton rb2 = new JRadioButton("Medium");
        JRadioButton rb3 = new JRadioButton("Hard");
        rg.add(rb1);
        rg.add(rb2);
        rg.add(rb3);
        rb1.setBounds(10, 270, 100, 40);
        rb1.setBounds(10, 300, 100, 40);
        rb1.setBounds(10, 330, 100, 40);
        f.add(rb1);
        f.add(rb2);
        f.add(rb3);

        String[] item = { "Amreli", "Bhavnagar", "Mumbai", "Delhi", "Jammu" };
        JList<String> lst = new JList<>(item);
        lst.setBounds(150, 100, 75, 75);
        f.add(lst);

        String[] citystr = { "Amreli", "Bhavnagar", "Mumbai", "Delhi", "Jammu" };
        JComboBox<String> cities = new JComboBox<>(citystr);
        cities.setSelectedIndex(3);
        cities.setBounds(150, 200, 100, 50);
        f.add(cities);

        f.setSize(300, 400);
        f.setLayout(null);
        f.setVisible(true);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }

    public static void main(String[] args) {
        new SwingComponentDemo();
    }
}
