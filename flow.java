package lesson1;
// import
import javax.swing.*;
import java.awt.FlowLayout;
public class flow {
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		// create frame
		JFrame frame = new JFrame ("FlowLayout");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize (400, 500);
		
		// new button
		JButton b1 = new JButton ("bttn1");
		JButton b2 = new JButton ("bttn2");
		JButton b3 = new JButton ("bttn3");
		JButton b4 = new JButton ("bttn4");
		JButton b5 = new JButton ("bttn5");
		
		// new panel
		JPanel panel = new JPanel ();
		panel.setLayout (new FlowLayout());
		
		// add button to panel
		panel.add(b1);
		panel.add(b2);
		panel.add(b3);
		panel.add(b4);
		panel.add(b5);
		
		// add panel to frame
		frame.add(panel);
		
		// iluu zai baihguigeer bagtslah
		frame.pack();
		frame.setVisible (true);
	}

}
