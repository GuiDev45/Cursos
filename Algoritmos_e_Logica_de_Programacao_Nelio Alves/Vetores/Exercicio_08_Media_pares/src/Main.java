import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos elementos vai ter o vetor? ");
		int N = sc.nextInt();
		
		int vect[] = new int[N];
		
		double media = 0;
		int soma = 0;
		int contPar = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Digite um número: ");
			vect[i] = sc.nextInt();
			soma += vect[i];
			if (vect[i] % 2 == 0) {
				media = soma / N;
				contPar += 1;
			}
		}

		if (contPar == 0) {
			System.out.println("NENHUM NÚMERO PAR");
		} 
		else {
			System.out.printf("MÉDIA DOS PARES = %.1f", media);
		}
		
		sc.close();

	}

}
