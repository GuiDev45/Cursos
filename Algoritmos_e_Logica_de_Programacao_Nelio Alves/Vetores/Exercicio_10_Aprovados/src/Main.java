import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Quantos alunos serão digitados? ");
		int N = sc.nextInt();

		String vectNome[] = new String[N];
		double vectA[] = new double[N];
		double vectB[] = new double[N];

		double media = 0;

		for (int i = 0; i < N; i++) {
			System.out.printf("Digite nome, primeira e segunda nota do %do aluno:%n", i+1);
			sc.nextLine();
			vectNome[i] = sc.nextLine();
			vectA[i] = sc.nextDouble();
			vectB[i] = sc.nextDouble();
		}

		for (int i = 0; i < N; i++) {
			media = (vectA[i] + vectB[i]) / 2;
			if (media >= 6.0) {
				System.out.printf("%s%n", vectNome[i]);
			}
		}

		sc.close();

	}

}
