import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Qual a ordem da matriz? ");
		int N = sc.nextInt();

		int mat[][] = new int[N][N];

		int soma = 0;

		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				System.out.printf("Elemento [%d,%d]: ", i, j);
				mat[i][j] = sc.nextInt();
			}
		}

		for (int i = 0; i < N; i++) {
			for (int j = i + 1; j < N; j++) {
				soma += mat[i][j];
			}
		}

		System.out.printf("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = %d", soma);

		sc.close();

	}

}
