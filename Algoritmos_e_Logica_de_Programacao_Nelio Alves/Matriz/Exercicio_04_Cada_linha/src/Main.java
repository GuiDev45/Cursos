import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Qual a ordem da matriz? ");
		int N = sc.nextInt();

		int mat[][] = new int[N][N];
		int maior = 0;

		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				System.out.printf("Elemento [%d,%d]: ", i, j);
				mat[i][j] = sc.nextInt();
			}
		}

		System.out.println("MAIOR ELEMENTO DE CADA LINHA:");

		for (int i = 0; i < N; i++) {
			maior = mat[i][0];
			for (int j = 0; j < N; j++) {
				if (mat[i][j] > maior) {
					maior = mat[i][j];
				}
			}
			System.out.printf("%d%n", maior);
		}

		sc.close();

	}

}
