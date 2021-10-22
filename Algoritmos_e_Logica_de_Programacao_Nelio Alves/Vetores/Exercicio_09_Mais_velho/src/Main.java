import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.print("Quantas pessoas você vai digitar? ");
		int N = sc.nextInt();
		
		String vectNome[] = new String[N];
		int vectIdade[] = new int[N];
		
		int maior = 0;
		int posMaior = 0;
		
		for (int i = 0; i < N; i++) {
			System.out.printf("Dados da %da pessoa:%n", i+1);
			System.out.print("Nome: ");
			sc.nextLine();
			vectNome[i] = sc.nextLine();
			System.out.print("Idade: ");
			vectIdade[i] = sc.nextInt();
			if (vectIdade[i] > maior) {
				maior = vectIdade[i];
				posMaior = i;
			}
		}
		
		System.out.printf("PESSOA MAIS VELHA: %s", vectNome[posMaior]);
		
		sc.close();

	}

}
