import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);

		System.out.print("Informe um codigo (1, 2, 3) ou 4 para parar: ");
		int codigo = sc.nextInt();

		int alcool = 0;
		int gasolina = 0;
		int diesel = 0;

		while (codigo != 4) {
			if (codigo == 1) {
				alcool += 1;
			}
			if (codigo == 2) {
				gasolina += 1;
			}
			if (codigo == 3) {
				diesel += 1;
			}
			System.out.print("Informe um codigo (1, 2, 3) ou 4 para parar: ");
			codigo = sc.nextInt();
		}

		System.out.println("MUITO OBRIGADO");

		System.out.printf("Alcool: %d%n", alcool);
		System.out.printf("Gasolina: %d%n", gasolina);
		System.out.printf("Diesel: %d", diesel);

		sc.close();

	}

}
