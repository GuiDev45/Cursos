import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.print("Qual a ordem da matriz? ");
		int N = sc.nextInt();
		
		int mat[][] = new int [N][N];
		
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				System.out.printf("Elemento [%d,%d]: ", i, j);
				mat[i][j] = sc.nextInt();
			}
		}
		
		System.out.println("DIAGONAL PRINCIPAL:");
		
		int negativo = 0;
		
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				if (mat[i][j] < 0) {
					negativo += 1;
				}
				if (i == j) {
					System.out.printf("%d ", mat[i][j]);
				}
			}
		}
		
		System.out.println();
		System.out.printf("QUANTIDADE DE NEGATIVOS = %d", negativo);
		
		sc.close();

	}

}
