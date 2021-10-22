import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.print("Primeiro valor: ");
		int primeiro = sc.nextInt();
		System.out.print("Segundo valor: ");
		int segundo = sc.nextInt();
		System.out.print("Terceiro valor: ");
		int terceiro = sc.nextInt();
		
		if (primeiro <= segundo && segundo <= terceiro) {
			System.out.printf("MENOR = %d", primeiro);
		}
		else if (segundo <= primeiro) {
			System.out.printf("MENOR = %d", segundo);
		}
		else {
			System.out.printf("MENOR = %d", terceiro);
		}
		
		sc.close();

	}

}
