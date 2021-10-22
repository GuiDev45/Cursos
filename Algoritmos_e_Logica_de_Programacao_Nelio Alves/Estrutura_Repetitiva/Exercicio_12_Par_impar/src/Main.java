import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos números você vai digitar? ");
		int N = sc.nextInt();
		
		int num = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Digite um número: ");
			num = sc.nextInt();
			if (num > 0 && num % 2 == 0) {
				System.out.println("PAR POSITIVO");
			}
			else if (num < 0 && num % 2 == 0) {
				System.out.println("PAR NEGATIVO");
			}
			else if (num > 0 && num % 2 != 0) {
				System.out.println("IMPAR POSITIVO");
			}
			else if (num < 0 && num % 2 != 0) {
				System.out.println("IMPAR NEGATIVO");
			}
			else {
				System.out.println("NULO");
			}
		}
		
		sc.close();

	}

}
