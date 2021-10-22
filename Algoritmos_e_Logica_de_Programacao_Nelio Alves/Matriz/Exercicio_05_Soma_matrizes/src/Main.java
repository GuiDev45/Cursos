import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantas linhas vai ter cada matriz? ");
		int M = sc.nextInt();
		System.out.print("Quantas colunas vai ter cada matriz? ");
		int N = sc.nextInt();
		
		int matA[][] = new int[M][N];
		int matB[][] = new int[M][N];
		int matSoma[][] = new int[M][N];
		
		System.out.println("Digite os valores da matriz A:");
		for (int i = 0; i < M; i++) {
			for (int j = 0; j < N; j++) {
				System.out.printf("Elemento [%d,%d]: ", i, j);
				matA[i][j] = sc.nextInt();
			}
		}
		
		System.out.println("Digite os valores da matriz B:");
		for (int i = 0; i < M; i++) {
			for (int j = 0; j < N; j++) {
				System.out.printf("Elemento [%d,%d]: ", i, j);
				matB[i][j] = sc.nextInt();
			}
		}
		
		System.out.println("MATRIZ SOMA:");
		for (int i = 0; i < M; i++) {
			for (int j = 0; j < N; j++) {
				matSoma[i][j] = matA[i][j] + matB[i][j];
				System.out.printf("%d ", matSoma[i][j]);
			}
			System.out.println();
		}
		
		sc.close();

	}

}
