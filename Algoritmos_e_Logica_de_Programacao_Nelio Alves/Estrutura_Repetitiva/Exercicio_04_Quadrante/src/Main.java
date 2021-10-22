import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.println("Digite os valores das coordenadas X e Y:");
		double x = sc.nextDouble();
		double y = sc.nextDouble();

		while (x != 0 && y != 0) {
			if (x > 0 && y > 0) {
				System.out.println("QUADRANTE Q1");
			}
			if (x < 0 && y > 0) {
				System.out.println("QUADRANTE Q2");
			}
			if (x < 0 && y < 0) {
				System.out.println("QUADRANTE Q3");
			}
			if (x > 0 && y < 0) {
				System.out.println("QUADRANTE Q4");
			}
			System.out.println("Digite os valores das coordenadas X e Y:");
			x = sc.nextDouble();
			y = sc.nextDouble();
		}

		sc.close();

	}

}
