import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Código do produto comprado: ");
		int codigo = sc.nextInt();
		
		System.out.print("Quantidade comprada: ");
		int quantidade = sc.nextInt();
		
		double produto = 0;
		
		switch (codigo) {
		case 1:
			produto = 5.00;
			break;
		case 2:
			produto = 3.50;
			break;
		case 3:
			produto = 4.80;
			break;
		case 4:
			produto = 8.90;
			break;
		case 5:
			produto = 7.32;
			break;
		}
		
		double total = quantidade * produto;
		System.out.printf("Valor a pagar: R$ %.2f", total);
		
		sc.close();

	}

}
