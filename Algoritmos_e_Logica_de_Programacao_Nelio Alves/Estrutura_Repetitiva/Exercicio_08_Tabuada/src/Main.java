import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Deseja a tabuada para qual valor? ");
		int N = sc.nextInt();

		int resultado = 0;

		for (int i = 1; i <= 10; i++) {
			resultado = N * i;
			System.out.printf("%d x %d = %d%n", N, i, resultado);
		}

		sc.close();

	}

}
