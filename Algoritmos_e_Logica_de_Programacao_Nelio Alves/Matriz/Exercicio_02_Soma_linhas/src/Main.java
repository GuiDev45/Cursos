import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Qual a quantidade de linhas da matriz? ");
		int M = sc.nextInt();
		System.out.print("Qual a quantidade de colunas da matriz? ");
		int N = sc.nextInt();

		double mat[][] = new double[M][N];

		double vectSoma[] = new double[M];

		for (int i = 0; i < M; i++) {
			System.out.printf("Digite os elementos da %da. linha%n", i+1);
			for (int j = 0; j < N; j++) {
				mat[i][j] = sc.nextDouble();
			}
		}

		for (int i = 0; i < M; i++) {
			for (int j = 0; j < N; j++) {
				vectSoma[i] += mat[i][j];
			}
		}

		System.out.println("VETOR GERADO:");
		for (int i = 0; i < M; i++) {
			System.out.printf("%.1f%n", vectSoma[i]);
		}

		sc.close();

	}

}
