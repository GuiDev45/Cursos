import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Preço unitário do produto: ");
		double precoUni = sc.nextDouble();
		
		System.out.print("Quantidade comprada: ");
		int quantidade = sc.nextInt();
		
		System.out.print("Dinheiro recebido: ");
		double pagDinheiro = sc.nextDouble();
		
		double troco = pagDinheiro - quantidade * precoUni;
		
		System.out.printf("TROCO = %.2f", troco);
		
		sc.close();

	}

}
