import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Distancia percorrida: ");
		int distancia = sc.nextInt();
		
		System.out.print("Combustível gasto: ");
		double combGasto = sc.nextDouble();
		
		double consumoMedio = (double)distancia / combGasto;
		
		System.out.printf("Consumo médio = %.3f", consumoMedio);
		
		sc.close();

	}

}
