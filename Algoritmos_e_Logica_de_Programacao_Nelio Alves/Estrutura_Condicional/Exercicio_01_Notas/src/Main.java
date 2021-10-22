import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		System.out.print("Digite a primeira nota: ");
		double nota1 = sc.nextDouble();
		
		System.out.print("Digite a segunda nota: ");
		double nota2 = sc.nextDouble();
		
		double soma = nota1 + nota2;

		if (soma >= 60.0) {
			System.out.printf("NOTA FINAL = %.1f", soma);
		}
		else {
			System.out.printf("NOTA FINAL = %.1f%nREPROVADO", soma);
		}
		
		/*
		OPÇÃO COM OPERADOR TERNÁRIO.
		System.out.println((soma >= 60.0) ? "NOTA FINAL = " + soma : "NOTA FINAL = " + soma + "\nREPROVADO");
		*/
		
		sc.close();

	}

}
