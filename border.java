package lesson1;
import javax.swing.*;
import java.awt.*;
public class border {
	private static void creatUI (final JFrame frame) {
		// new button
		JButton b1 = new JButton ("bttn1");
		JButton b2 = new JButton ("bttn2");
		JButton b3 = new JButton ("bttn3");
		JButton b4 = new JButton ("bttn4");
		JButton b5 = new JButton ("bttn5");
		JButton b6 = new JButton ("bttn6");
		JButton b7 = new JButton ("bttn7");
		JButton b8 = new JButton ("bttn8");
		JButton b9 = new JButton ("bttn9");
		
		// new center panel
		JPanel centerPanel = new JPanel ();
		centerPanel.setLayout (new FlowLayout());
		centerPanel.add(b6);
		centerPanel.add(b7);
		centerPanel.add(b8);
		centerPanel.add(b9);
		// new panel
		JPanel panel = new JPanel ();
		// grid layout deer mor baganiig zaaj ogch bga 3mor 2bagana gsn ni 
		panel.setLayout (new BorderLayout(1, 2));
		
		// add button to panel
		panel.add(centerPanel, BorderLayout.NORTH);
		panel.add(b2, BorderLayout.WEST);
		panel.add(b3, BorderLayout.EAST);
		panel.add(b4, BorderLayout.SOUTH);
		panel.add(b5, BorderLayout.CENTER);
		frame.add(panel);
	}
	private static void createFrame () {
		JFrame frame = new JFrame ("BorderLayout");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize (400, 500);
		creatUI(frame);
		frame.setVisible (true);
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		createFrame ();
	}

}
