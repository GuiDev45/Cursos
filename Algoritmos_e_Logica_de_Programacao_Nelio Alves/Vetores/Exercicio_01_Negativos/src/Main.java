import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Quantos n�meros voc� vai digitar? ");
		int N = sc.nextInt();

		int vect[] = new int[N];

		if (N <= 10) {
			for (int i = 0; i < N; i++) {
				System.out.print("Digite um n�mero: ");
				vect[i] = sc.nextInt();
			}
		}

		System.out.println("N�MEROS NEGATIVOS:");
		for (int i = 0; i < N; i++) {
			if (vect[i] < 0) {
				System.out.printf("%d%n", vect[i]);
			}
		}
		
		sc.close();

	}

}
