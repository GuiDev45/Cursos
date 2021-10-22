import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		int x, num2, num3, num4, num5, total;

		System.out.print("Digite um número inteiro: ");
		x = sc.nextInt();

		while (x != 0) {
			if (x % 2 == 0) {
				num2 = x + 2;
				num3 = x + 2 + 2;
				num4 = x + 2 + 2 + 2;
				num5 = x + 2 + 2 + 2 + 2;
				total = x + num2 + num3 + num4 + num5;
				System.out.printf("SOMA = %d%n", total);
				System.out.print("Digite um número inteiro: ");
				x = sc.nextInt();
			} 
			else if (x % 2 != 0) {
				x += +1;
				num2 = x + 2;
				num3 = x + 2 + 2;
				num4 = x + 2 + 2 + 2;
				num5 = x + 2 + 2 + 2 + 2;
				total = x + num2 + num3 + num4 + num5;
				System.out.printf("SOMA = %d%n", total);
				System.out.print("Digite um número inteiro: ");
				x = sc.nextInt();
			}
		}

		sc.close();

	}

}
