import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos números você vai digitar? ");
		int N = sc.nextInt();
		
		int vect[] = new int [N];
		int quant = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Digite um número: ");
			vect[i] = sc.nextInt();
		}
		
		System.out.println();
		
		System.out.println("NÚMEROS PARES: ");
		for (int i = 0; i < N; i++) {
			if (vect[i] % 2 == 0) {
				quant += 1;
				System.out.printf("%d  ", vect[i]);
			}
		}
		
		System.out.println();
		System.out.println();
		
		System.out.printf("QUANTIDADE DE PARES = %d", quant);
		
		sc.close();

	}

}
