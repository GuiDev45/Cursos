import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite o valor do raio do circulo: ");
		double raio = sc.nextDouble();
		
		double area =  Math.PI * Math.pow(raio, 2);
		// A fun��o Math.pow(n�mero, expoente) calcula a pot�ncia.
		
		System.out.printf("AREA = %.3f", area);
		
		sc.close();

	}

}
