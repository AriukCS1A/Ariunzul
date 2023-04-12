package lesson1;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
public class calculator extends JFrame implements ActionListener {
	static JFrame frame;
	static String s0, s1, s2;
	static JTextField txt;
	public calculator () {
		s0 = s1 = s2 = "";
	}
	private static void createUI (final JFrame frame) {
		txt = new JTextField (20);
		txt.setEditable(false);
		calculator c = new calculator ();
		JButton b0, b1, b2, b3, b4, b5, b6, b7, b8, b9, bAdd, bSubs, bDiv, bMul, bClear, bPoint, bEq;
		b0 = new JButton ("0");
		b1 = new JButton ("1");
		b2 = new JButton ("2");
		b3 = new JButton ("3");
		b4 = new JButton ("4");
		b5 = new JButton ("5");
		b6 = new JButton ("6");
		b7 = new JButton ("7");
		b8 = new JButton ("8");
		b9 = new JButton ("9");
		bAdd = new JButton ("+");
		bSubs = new JButton ("-");
		bDiv = new JButton ("/");
		bMul = new JButton ("*");
		bClear = new JButton ("C");
		bPoint = new JButton (".");
		bEq = new JButton ("=");
		
		b0.addActionListener(c);
		b1.addActionListener(c);
		b2.addActionListener(c);
		b3.addActionListener(c);
		b4.addActionListener(c);
		b5.addActionListener(c);
		b6.addActionListener(c);
		b7.addActionListener(c);
		b8.addActionListener(c);
		b9.addActionListener(c);
		bAdd.addActionListener(c);
		bSubs.addActionListener(c);
		bDiv.addActionListener(c);
		bMul.addActionListener(c);
		bClear.addActionListener(c);
		bPoint.addActionListener(c);
		bEq.addActionListener(c);
		
		// text panel
		JPanel textPanel = new JPanel ();
		textPanel.setLayout (new FlowLayout());
		textPanel.add(txt);
		JPanel btnPanel = new JPanel ();
		btnPanel.setLayout (new GridLayout(5, 4));
		btnPanel.add(b1);
		btnPanel.add(b2);
		btnPanel.add(b3);
		btnPanel.add(bAdd);
		btnPanel.add(b4);
		btnPanel.add(b5);
		btnPanel.add(b6);
		btnPanel.add(bSubs);
		btnPanel.add(b7);
		btnPanel.add(b8);
		btnPanel.add(b9);
		btnPanel.add(bMul);
		btnPanel.add(bPoint);
		btnPanel.add(b0);
		btnPanel.add(bClear);
		btnPanel.add(bDiv);
		btnPanel.add(bEq);
		JPanel mainPanel = new JPanel ();
		mainPanel.setLayout (new BorderLayout());
		mainPanel.add (textPanel, BorderLayout.NORTH);
		mainPanel.add (btnPanel, BorderLayout.CENTER);
		
		frame.add (mainPanel);
		frame.setVisible(true);
	
		
	}
	private static void createFrame () {
		frame = new JFrame ("CS Calculator");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setSize (400, 500);
		frame.setVisible (true);
		createUI (frame);
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		createFrame();
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub
		String s = e.getActionCommand();
		if ((s.charAt(0) >= '0' && s.charAt(0)<='9') || s.charAt(0) == '.') {
			txt.setText(s);
			if (s1.equals("") && s2.equals("")){
				s0 = s0 + s;
			}
			else if (!s1.equals("")) {
				s2 = s2 + s;
			}
			txt.setText(s0 + s1 + s2);
		}
		else if (s.charAt(0) == 'C') {
			s0=s1=s2="";
			txt.setText(s0+s1+s2);
		}
		else if (s.charAt(0) == '=') {
			double result = 0;
			if (s1.equals("+")){
				result = Double.parseDouble (s0) + Double.parseDouble (s2);
			}
			else if (s1.equals("-")){
				result = Double.parseDouble (s0) - Double.parseDouble (s2);
			}
			else if (s1.equals("/")){
				result = Double.parseDouble (s0) / Double.parseDouble (s2);
			}
			else if (s1.equals("*")){
				result = Double.parseDouble (s0) * Double.parseDouble (s2);
			}
			txt.setText(s0+s1+s2+"=" + Double.valueOf(result));
		}
		else {
			double result = 0;
 			if (!s1.equals ("") && !s2.equals("")) {
				if (s.equals("+")){
					result = Double.parseDouble (s0) + Double.parseDouble (s2);
				}
				else if (s.equals("-")){
					result = Double.parseDouble (s0) - Double.parseDouble (s2);
				}
				else if (s.equals("/")){
					result = Double.parseDouble (s0) / Double.parseDouble (s2);
				}
				else if (s.equals("*")){
					result = Double.parseDouble (s0) * Double.parseDouble (s2);
				}
				s0 = Double.toString (result);
				s2 = "";
				s1 = s;
			}
 			else if (!s0.equals("")) {
 				s1 = s;
 			}
 			txt.setText (s0+s1+s2);
		}
	}
}
