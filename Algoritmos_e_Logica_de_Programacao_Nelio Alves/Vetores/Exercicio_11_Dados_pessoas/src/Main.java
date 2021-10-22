import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Quantos pessoas serão digitadas? ");
		int N = sc.nextInt();

		double vectAltura[] = new double[N];
		char vectGenero[] = new char[N];

		double media = 0;
		double soma = 0;
		int contF = 0;
		int contM = 0;

		for (int i = 0; i < N; i++) {
			System.out.printf("Altura da %da pessoa: ", i + 1);
			vectAltura[i] = sc.nextDouble();
			System.out.printf("Gênero da %da pessoa: ", i + 1);
			vectGenero[i] = sc.next().charAt(0);
		}

		double maiorAltura = vectAltura[0];
		double menorAltura = vectAltura[0];

		for (int i = 0; i < N; i++) {
			if (vectAltura[i] > maiorAltura) {
				maiorAltura = vectAltura[i];
			} 
			else if (vectAltura[i] < menorAltura) {
				menorAltura = vectAltura[i];
			}
		}

		System.out.printf("Menor altura = %.2f%n", menorAltura);
		System.out.printf("Maior altura = %.2f%n", maiorAltura);

		for (int i = 0; i < N; i++) {
			if (vectGenero[i] == 'F') {
				contF += 1;
				soma += vectAltura[i];
			}
		}

		media = soma / contF;

		System.out.printf("Média das alturas das mulheres = %.2f%n", media);

		for (int i = 0; i < N; i++) {
			if (vectGenero[i] == 'M') {
				contM += 1;
			}
		}

		System.out.printf("Número de homens = %d", contM);

		sc.close();

	}

}
