import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos casos você vai digitar? ");
		int N = sc.nextInt();
		
		int numerador = 0;
		int denominador = 0;
		double resultado = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Entre com o numerador: ");
			numerador = sc.nextInt();
			System.out.print("Entre com o denominador: ");
			denominador = sc.nextInt();
			if (numerador < 0 && denominador == 0) {
				System.out.println("DIVISÃO IMPOSSÍVEL");
			}
			else {
				resultado = (double)numerador / denominador;
				System.out.printf("DIVISÃO = %.2f%n", resultado);
			}
		}
		
		sc.close();

	}

}
