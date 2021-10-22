import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Serão digitados dados de quantos produtos? ");
		int N = sc.nextInt();

		String vectNome[] = new String[N];
		double vectCompra[] = new double[N];
		double vectVenda[] = new double[N];

		for (int i = 0; i < N; i++) {
			System.out.printf("Produto %d:%n", i + 1);
			System.out.print("Nome: ");
			sc.nextLine();
			vectNome[i] = sc.nextLine();
			System.out.print("Preço de compra: ");
			vectCompra[i] = sc.nextDouble();
			System.out.print("Preço de venda: ");
			vectVenda[i] = sc.nextDouble();
		}

		int abaixo = 0;
		int entre = 0;
		int acima = 0;
		double lucro = 0;
		double percentualLucro = 0;

		for (int i = 0; i < N; i++) {
			lucro = vectVenda[i] - vectCompra[i];
			percentualLucro = lucro * 100 / vectCompra[i];
			if (percentualLucro < 10) {
				abaixo += 1;
			} else if (percentualLucro <= 20) {
				entre += 1;
			} else {
				acima += 1;
			}
		}

		double totalCompra = 0;
		double totalVenda = 0;

		for (int i = 0; i < N; i++) {
			totalCompra += vectCompra[i];
			totalVenda += vectVenda[i];
		}

		double totalLucro = totalVenda - totalCompra;

		System.out.println("RELATORIO:");
		System.out.printf("Lucro abaixo de 10: %d%n", abaixo);
		System.out.printf("Lucro entre 10 e 20: %d%n", entre);
		System.out.printf("Lucro acima de 20: %d%n", acima);
		System.out.printf("Valor total de compra: %.2f%n", totalCompra);
		System.out.printf("Valor total de venda: %.2f%n", totalVenda);
		System.out.printf("Lucro total: %.2f%n", totalLucro);
		
		sc.close();

	}

}
