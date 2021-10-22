import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantos casos de teste serão digitados? ");
		int N = sc.nextInt();
		
		int quant = 0;
		int coelho = 0;
		int rato = 0;
		int sapo = 0;
		int totalC = 0;
		
		double porcentagemC = 0;
		double porcentagemR = 0;
		double porcentagemS = 0;
		
		char cobaia;
		
		for (int i = 0; i < N; i++) {
			System.out.print("Quantidade de cobaias: ");
			quant = sc.nextInt();
			System.out.print("Tipo de Cobaia: ");
			cobaia = sc.next().charAt(0);
			if (cobaia == 'C') {
				coelho += quant;
			}
			if (cobaia == 'R') {
				rato += quant;
			}
			if (cobaia == 'S') {
				sapo += quant;
			}
		}
		
		totalC = coelho + rato + sapo;
		System.out.println("RELATORIO FINAL:");
		System.out.printf("Total: %d cobaias%n", totalC);
		
		System.out.printf("Total de coelhos: %d%n", coelho);
		System.out.printf("Total de ratos: %d%n", rato);
		System.out.printf("Total de sapos: %d%n", sapo);
		
		porcentagemC = (double)coelho * 100 / totalC;
		porcentagemR = (double)rato * 100 / totalC;
		porcentagemS = (double)sapo * 100 / totalC;
		System.out.printf("Percentual de coelhos: %.2f%n", porcentagemC);
		System.out.printf("Percentual de ratos: %.2f%n", porcentagemR);
		System.out.printf("Percentual de sapos: %.2f", porcentagemS);
		
		sc.close();

	}

}
