import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite o valor de N: ");
		int N = sc.nextInt();
		
		int fact = 1;
		
		if (N <= 15) {
			for (int i = 1; i <= N; i++) {
				fact *= i;
			}
		}

		System.out.printf("FATORIAL = %d", fact);
		
		sc.close();

	}

}
