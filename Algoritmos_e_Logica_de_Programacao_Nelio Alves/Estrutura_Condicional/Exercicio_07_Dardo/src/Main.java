import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Digite as tr�s dist�ncias:");
		double a = sc.nextDouble();
		double b = sc.nextDouble();
		double c = sc.nextDouble();
		
		if (a > b && a > c) {
			System.out.printf("MAIOR DIST�NCIA = %.2f", a);
		}
		else if (b > c) {
			System.out.printf("MAIOR DIST�NCIA = %.2f", b);
		}
		else {
			System.out.printf("MAIOR DIST�NCIA = %.2f", c);
		}
		
		sc.close();

	}

}
