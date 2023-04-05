package lesson1;

import javax.swing.*;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class window {
	static boolean visibility = true;
	static boolean disable = false;
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JFrame  frame = new JFrame ();
		
		// create label
		JLabel lbl = new JLabel ("Hello Swing UI");
		lbl.setBounds (150, 20, 100, 40);
		
		// create button
		JButton btnClick = new JButton ("Click me");
		btnClick.setBounds (100, 100, 90, 40);
		btnClick.setBackground(Color.yellow);
		
		// create button1
		JButton btnPress = new JButton ("Press me");
		btnPress.setBounds (200, 100, 90, 40);
		btnPress.setBackground(Color.pink);
		
		// create delete button
		JButton btnDelete = new JButton ("Delete");
		btnDelete.setBounds (100, 150, 90, 40);
		btnDelete.setBackground(Color.blue);
		
		// hide and show
		JButton btnHideShow = new JButton ("Hide/Show");
		btnHideShow.setBounds (200, 150, 90, 40);
		btnHideShow.setBackground(Color.green);
		
		// disable button
		JButton btnDisable = new JButton ("Disable");
		btnDisable.setBounds (100, 200, 90, 40);
		btnDisable.setBackground(Color.pink);
		
		//edit button
		JButton btnEdit = new JButton ("Edit");
		btnEdit.setBounds (200, 200, 90, 40);
		btnDisable.setBackground(Color.green);
		
		// textbox
		JTextField txt = new JTextField ();
		txt.setBounds(100, 55, 200, 30);
		
		// framed (window) lbl bolon buttonoo nemeh
		frame.setDefaultCloseOperation (JFrame.EXIT_ON_CLOSE);
		frame.add(lbl);
		frame.add (btnClick);
		frame.add (btnPress);
		frame.add (btnDelete);
		frame.add (btnHideShow);
		frame.add (txt);
		frame.add (btnDisable);
		frame.add (btnEdit);
		
		// windowiin zagvariig zaaj ogoh
		frame.getContentPane().setBackground(Color.WHITE);
		frame.setLayout (null);
		frame.setSize (400, 500);
		frame.setVisible (true); 
		
		// buttong darahad uildel hiideg bolgoh
		
		btnClick.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				lbl.setText(btnClick.getText());
			}});
		
		btnPress.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				lbl.setText(btnPress.getText());
			}});
		
		btnDelete.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				txt.setText("");
			}});
		
		// labeliin textiig nuugaad gargaj bga
		btnHideShow.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				if (visibility) {
					visibility = false; 
				}
				else {
					visibility = true;
				}
				lbl.setVisible(visibility);
			}});
		txt.addKeyListener(new KeyListener () {

			@Override
			public void keyTyped(KeyEvent e) {
				// TODO Auto-generated method stub
			}

			@Override
			public void keyPressed(KeyEvent e) {
				// TODO Auto-generated method stub
			}

			@Override
			public void keyReleased(KeyEvent e) {
				// TODO Auto-generated method stub
				lbl.setText(txt.getText());
				
			}});
		btnDisable.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				if (txt.isEnabled ()) {
					txt.setEnabled (false);
				}
				else {
					txt.setEnabled (true);
					}
			}});
		btnEdit.addActionListener(new ActionListener() {

			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				if (txt.isEditable ()) {
					txt.setEditable (false);
				}
				else {
					txt.setEditable (true);
					}
			}});
		btnPress.addMouseListener (new MouseListener() {
			@Override
			public void mouseClicked(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void mousePressed(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub
				btnPress.setBackground(Color.decode("#CCE5FF"));
			}

			@Override
			public void mouseExited(MouseEvent e) {
				// TODO Auto-generated method stub
				btnPress.setBackground(Color.white);
				
			}});
	}

}
