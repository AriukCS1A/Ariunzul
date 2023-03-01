package february15;
import java.util.Scanner;
public class calculator {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int a;
		int b;
		char c;
		Scanner scan = new Scanner (System.in);
		System.out.println("Enter your first number: ");
		a = scan.nextInt();
		System.out.println("Enter your second number: ");
		b = scan.nextInt();
		scan.nextLine();
		System.out.println("Enter your operation: ");
		c = scan.nextLine().charAt(0);
		
		System.out.println("1st number " + a);
		System.out.println("2nd number " + b);
		
		if (c == '+') {
			System.out.println(a + b);
		}
		else if (c == '-') {
			System.out.println(a - b);
		}
		else if (c == '*') {
			System.out.println(a * b);	
		}
		else {
			System.out.println(a / b);
		}
		scan.close();
	}

}
