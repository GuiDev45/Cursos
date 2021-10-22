import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		int Hinicial, Hfinal, tempo;

		System.out.print("Hora inicial: ");
		Hinicial = sc.nextInt();

		System.out.print("Hora final: ");
		Hfinal = sc.nextInt();

		if (Hinicial < Hfinal) {
			tempo = Hfinal - Hinicial;
		} 
		else {
			tempo = 24 - Hinicial + Hfinal;
		}

		System.out.printf("O JOGO DUROU %d HORA(S)", tempo);

		sc.close();

	}

}
