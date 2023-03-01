package february15;

import java.util.Scanner;
public class lesson1 {
	public static void main (String[] args) {
		// TODO Auto generated method stub
		System.out.println("hello world");
		
		// ---------------VARIABLES----------------
		
		// declaration
		char c;
		
		// initialize
		c = 'T';
		
		// declare and initialize
		
		char cc = 'A';
		System.out.println("char cc is " + cc);
		
		int x = 5;
		System.out.println("int x is " + x);
		
		boolean check = true;
		System.out.println ("boolean check is " + check);
		
		String str = "This is my first Java class";
		System.out.println("String str is: " + str);
		
		byte age = 26;
		System.out.println("my age is " + age);
		
		long long_int = 12433;
		
		int int_x = 123445467;
		
		float frac = 2.444f;
		double long_frac = 2.555;
		System.out.println(frac + " " + long_frac);
		
		// enter data SCAN integer
		
		Scanner scan = new Scanner (System.in);
		
		System.out.println("Enter your name: ");
		String name = scan.nextLine();
		
		// enter string scanner
		
		System.out.println("Enter your age: ");
		byte old = scan.nextByte();
		
		System.out.println("Your name is " + name);
		System.out.println("Your age is " + old);
		
		scan.close ();
	
		
		
		// ----------------- STATEMENTS ---------------
		// if (false){
			// System.out.println("if");
		// }
		// else if (false) {
			// System.out.println("else if");
		// }
		// else {
			// System.out.println("else");
		// }
	}

}
