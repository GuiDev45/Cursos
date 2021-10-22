import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		double C, F;

		System.out.print("Voce vai digitar a temperatura em qual escala (C/F)? ");
		char unidade = sc.next().charAt(0);

		if (unidade == 'F') {
			System.out.print("Digite a temperatura em Fahrenheit: ");
			F = sc.nextDouble();
			C = (F - 32) * 5.0 / 9.0;
			System.out.printf("Temperatura equivalente em Celsius: %.2f", C);
		} 
		else {
			System.out.print("Digite a temperatura em Celsius: ");
			C = sc.nextDouble();
			F = 9.0 * C / 5.0 + 32;
			System.out.printf("Temperatura equivalente em Fahrenheit: %.2f", F);
		}
		
		sc.close();

	}

}
