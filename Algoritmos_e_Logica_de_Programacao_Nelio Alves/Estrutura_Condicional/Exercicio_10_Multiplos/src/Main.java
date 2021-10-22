import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.println("Digite dois n�meros inteiros:");
		int a = sc.nextInt();
		int b = sc.nextInt();

		if (a % b == 0 || b % a == 0) {
			System.out.println("S�o m�ltiplos");
		}
		else {
			System.out.println("N�o s�o m�ltiplos");
		}

		sc.close();

	}

}
