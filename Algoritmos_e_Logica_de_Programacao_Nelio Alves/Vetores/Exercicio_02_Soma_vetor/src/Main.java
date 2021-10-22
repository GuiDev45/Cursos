import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos números você vai digitar? ");
		int N = sc.nextInt();
		
		double vect[] = new double [N];
		double soma = 0;
		double media = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Digite um número: ");
			vect[i] = sc.nextDouble();
			soma += vect[i];
		}
		
		System.out.println();
		System.out.printf("VALORES = ");
		for (int i = 0; i < N; i++) {
			System.out.printf("%.1f  ", vect[i]);
		}
		
		System.out.println();
		System.out.printf("SOMA = %.2f%n", soma);
		
		media = soma / N;
		System.out.printf("MÉDIA = %.2f", media);
		
		sc.close();

	}

}
