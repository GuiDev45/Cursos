import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Preço unitário do produto: ");
		double precoUni = sc.nextDouble();
		
		System.out.print("Quantidade comprada: ");
		int qtdCompra = sc.nextInt();
		
		System.out.print("Dinheiro recebido: ");
		double pagDinheiro = sc.nextDouble();
		
		double totalCompra = pagDinheiro - qtdCompra * precoUni;
		
		if (totalCompra < 0) {
			totalCompra = qtdCompra * precoUni - pagDinheiro;
			System.out.printf("DINHEIRO INSUFICIENTE. FALTAM %.2f REAIS", totalCompra);
		}
		else {
			System.out.printf("TROCO = %.2f", totalCompra);
		}
		
		sc.close();

	}

}
