import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.println("Digite as idades:");
		int idade = sc.nextInt();

		double soma = 0;
		double media = 0;
		int cont = 0;
		
		while (idade >= 0) {
			cont += 1;
			soma += idade;
			idade = sc.nextInt();
		}
		
		media = soma / cont;
		
		if (media >= 0) {
			media = soma / cont;
			System.out.printf("MÉDIA = %.2f", media);
		}
		else {
			System.out.println("IMPOSSIVEL CALCULAR");
		}

		sc.close();

	}

}
