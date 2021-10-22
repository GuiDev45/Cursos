import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos números você vai digitar? ");
		int N = sc.nextInt();
		
		int x = 0;
		int fora = 0;
		int dentro = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Digite um número: ");
			x = sc.nextInt();
			if (x >= 10 && x <= 20) {
				dentro += 1;
			}
			else {
				fora += 1;
			}
		}
		
		System.out.printf("%d DENTRO%n", dentro);
		System.out.printf("%d FORA", fora);
		
		sc.close();

	}

}
