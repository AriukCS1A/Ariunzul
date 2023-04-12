package lesson1;
import javax.swing.JFrame;
import javax.swing.JButton;
import javax.swing.JPanel;
public class boxlayout {
	private static void createFrame () {
		JFrame frame = new JFrame ("BoxLayout");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize (400, 500);
		
		JButton b1 = new JButton ("bttn1");
		JButton b2 = new JButton ("bttn2");
		JButton b3 = new JButton ("bttn3");
		JButton b4 = new JButton ("bttn4");
		JButton b5 = new JButton ("bttn5");
		
		JPanel panel = new JPanel ();
		panel.setLayout (new javax.swing.BoxLayout (panel, 1));
		
		panel.add(b1);
		panel.add(b2);
		panel.add(b3);
		panel.add(b4);
		panel.add(b5);
		
		frame.add (panel);
		frame.setVisible (true);
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		createFrame ();
	}

}
