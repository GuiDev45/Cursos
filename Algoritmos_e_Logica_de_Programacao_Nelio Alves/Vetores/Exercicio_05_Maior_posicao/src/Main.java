import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos números você vai digitar? ");
		int N = sc.nextInt();
		
		double vect[] = new double[N];
		double maiorV = 0;
		
		int posicao = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Digite um número: ");
			vect[i] = sc.nextDouble();
			if (vect[i] > maiorV) {
				maiorV = vect[i];
				posicao = i;
			}
		}
		
		System.out.println();
		
		System.out.printf("MAIOR VALOR = %.1f%n", maiorV);
		System.out.printf("POSIÇÃO DO MAIOR VALOR = %d", posicao);
		
		sc.close();

	}

}
