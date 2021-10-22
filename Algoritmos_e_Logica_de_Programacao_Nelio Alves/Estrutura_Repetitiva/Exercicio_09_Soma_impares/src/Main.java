import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.println("Digite dois números:");
		int x = sc.nextInt();
		int y = sc.nextInt();

		int soma = 0;

		if (x > y) {
			for (int i = x - 1; i > y; i--) {
				if (i % 2 != 0) {
					soma += i;
				}
			}
		}

		else {
			for (int i = x; i < y; i++) {
				if (i % 2 != 0) {
					soma += i;
				}
			}
		}

		System.out.printf("SOMA DOS IMPARES = %d", soma);

		sc.close();

	}

}
