import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos elementos vai ter o vetor? ");
		int N = sc.nextInt();
		
		double vect[] = new double[N];
		double media = 0;
		double soma = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Digite um número: ");
			vect[i] = sc.nextDouble();
			soma += vect[i];
		}
		
		System.out.println();
		
		media = soma / N;
		System.out.printf("MÉDIA DO VETOR = %.3f%n", media);
		
		System.out.println("ELEMENTOS ABAIXO DA MÉDIA:");
		for (int i = 0; i < N; i++) {
			if (vect[i] <= 10) {
				System.out.printf("%.1f%n", vect[i]);
			}
		}
		
		sc.close();

	}

}
