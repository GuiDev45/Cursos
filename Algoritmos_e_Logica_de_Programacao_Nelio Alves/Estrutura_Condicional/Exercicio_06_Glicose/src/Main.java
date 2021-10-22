import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite a medida da glicose: ");
		double medida = sc.nextDouble();
		
		if (medida <= 100) {
			System.out.print("Classificação: normal");
		}
		else if (medida >= 101 && medida <= 140) {
			System.out.print("Classificação: elevado");
		}
		else {
			System.out.print("Classificação: diabetes");
		}
		
		sc.close();

	}

}
