import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite a duração em segundos: ");
		int duracao = sc.nextInt();

		int hora = duracao / 3600;
		int resto = duracao % 3600;

		int minuto = resto / 60;
		int segundo = resto % 60;

		System.out.printf("%d:%d:%d", hora, minuto, segundo);
		
		sc.close();

	}

}
