import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantas pessoas serão digitadas? ");
		int N = sc.nextInt();
		
		String vectNome[] = new String[N];
		int vectIdade[] = new int[N];
		double vectAltura[] = new double[N];
		
		double mediaA = 0;
		double totalA = 0;
		double porcentagem = 0;
		
		int menorI = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.printf("Dados da %da pessoa:%n", i+1);
			System.out.print("Nome: ");
			sc.nextLine();
			vectNome[i] = sc.nextLine();
			System.out.print("Idade: ");
			vectIdade[i] = sc.nextInt();
			System.out.print("Altura: ");
			vectAltura[i] = sc.nextDouble();
			totalA += vectAltura[i];
			if (vectIdade[i] < 16) {
				menorI += 1;
			}
		}
		
		System.out.println();
		
		mediaA = totalA / N;
		System.out.printf("Altura média: %.2f%n", mediaA);
		
		porcentagem = (double)menorI * 100 / N;
		System.out.printf("Pessoas com menos de 16 anos: %.1f%n", porcentagem);
		
		for (int i = 0; i < N; i++) {
			if (vectIdade[i] < 16) {
				System.out.printf("%s%n", vectNome[i]);
			}
		}
		
		sc.close();

	}

}
