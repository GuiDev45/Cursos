import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Qual a ordem da matriz? ");
		int N = sc.nextInt();

		double mat[][] = new double[N][N];

		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				System.out.printf("Elemento [%d,%d]: ", i, j);
				mat[i][j] = sc.nextDouble();
			}
		}

		// a) calcular e imprimir a soma de todos os elementos positivos da matriz.
		double positivo = 0;

		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				if (mat[i][j] > 0) {
					positivo += mat[i][j];
				}
			}
		}
		
		System.out.println();
		System.out.printf("SOMA DOS POSITIVOS: %.1f%n", positivo);
		System.out.println();

		// b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
		int linha = 0;

		System.out.print("Esolha uma linha: ");
		linha = sc.nextInt();
		System.out.print("LINHA ESCOLHIDA:");
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
			}
			System.out.printf(" " + mat[linha][i]);
		}
		
		System.out.println();
		System.out.println();

		// c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
		int coluna = 0;

		System.out.print("Esolha uma coluna: ");
		coluna = sc.nextInt();
		System.out.print("COLUNA ESCOLHIDA:");
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
			}
			System.out.printf(" " + mat[i][coluna]);
		}
		
		System.out.println();
		System.out.println();

		// d) imprimir os elementos da diagonal principal da matriz.
		System.out.print("DIAGONAL PRINCIPAL:");
		for (int i = 0; i < N; i++) {
			System.out.print(" " + mat[i][i]);
		}
		
		System.out.println();

		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				if (mat[i][j] < 0) {
					mat[i][j] = Math.pow(mat[i][j], 2);
				}
			}
		}
		
		System.out.println();

		// e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
		System.out.println("MATRIZ ALTERADA:");
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				System.out.print(" " + mat[i][j]);
			}
			System.out.println();
		}

		sc.close();

	}

}
