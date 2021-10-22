import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Base do retangulo: ");
		double base = sc.nextDouble();
		
		System.out.print("Altura do retangulo: ");
		double altura = sc.nextDouble();
		
		double area = base * altura;
		double perimetro = (base + altura) * 2;
		double diagonal = Math.sqrt(Math.pow(base, 2.0) + Math.pow(altura, 2.0));
		// A fun��o Math.sqrt(x) retorna a raiz quadrada de um n�mero.
		// A fun��o Math.pow(n�mero, expoente) calcula a pot�ncia.
		
		System.out.printf("AREA = %.4f%n", area);
		System.out.printf("PERIMETRO = %.4f%n", perimetro);
		System.out.printf("DIAGONAL = %.4f", diagonal);
		
		sc.close();

	}

}
