import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Coeficiente a: ");
		double a = sc.nextDouble();
		System.out.print("Coeficiente b: ");
		double b = sc.nextDouble();
		System.out.print("Coeficiente c: ");
		double c = sc.nextDouble();
		
		double delta = (b * b) - (4 * a * c);
		double x1 = (-b + Math.sqrt(delta)) / (2 * a);
		double x2 = (-b - Math.sqrt(delta)) / (2 * a);
		//A função Math.sqrt() retorna a raiz quadrada de um número.
		
		if (delta < 0) {
			System.out.println("Esta equação não possui raizes reais");
		}
		else {
			System.out.printf("X1 = %.4f%n", x1);
			System.out.printf("X2 = %.4f%n", x2);
		}
		
		sc.close();

	}

}
