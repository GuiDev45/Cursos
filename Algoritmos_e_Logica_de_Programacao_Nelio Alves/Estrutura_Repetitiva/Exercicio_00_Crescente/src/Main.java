import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.println("Digite dois n�meros:");
		int x = sc.nextInt();
		int y = sc.nextInt();
		
		while (x != y) {
			if (x > y) {
				System.out.println("DECRESCENTE!");
			}
			else {
				System.out.println("CRESCENTE!");
			}
			System.out.println("Digite outros dois n�meros:");
			x = sc.nextInt();
			y = sc.nextInt();
		}
		
		sc.close();

	}

}
