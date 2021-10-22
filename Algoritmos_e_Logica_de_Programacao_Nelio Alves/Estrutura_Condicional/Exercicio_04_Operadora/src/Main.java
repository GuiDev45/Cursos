import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite a quantidade de minutos: ");
		int minuto = sc.nextInt();
		
		int plano = minuto;
		double pagar = 50.0;
		int taxa = minuto - 100;
		
		if (plano >= 101) {
			pagar += 2.0 * taxa;
			System.out.printf("Valor a pagar: R$ %.2f", pagar);
		}
		else {
			System.out.printf("Valor a pagar: R$ %.2f", pagar);
		}
		
		sc.close();

	}

}
