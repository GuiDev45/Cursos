import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos casos você vai digitar? ");
		int N = sc.nextInt();
		
		double num1 = 0;
		double num2 = 0;
		double num3 = 0;
		double media = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.println("Digite três números:");
			num1 = sc.nextDouble();
			num2 = sc.nextDouble();
			num3 = sc.nextDouble();
			media = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
			System.out.printf("MÉDIA = %.1f%n", media);
		}
		
		sc.close();

	}

}
