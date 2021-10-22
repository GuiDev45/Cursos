import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Digite o salário da pessoa: ");
		double salario = sc.nextDouble();
		
		double novoSal, aumento;
		int porcentagem;
		
		if (salario <= 1000.0) {
			porcentagem = 20;
			aumento = salario * porcentagem / 100;
			novoSal = salario + aumento;
		}
		else if (salario > 1000.0 && salario <= 3000.0) {
			porcentagem = 15;
			aumento = salario * porcentagem / 100;
			novoSal = salario + aumento;
		}
		else if (salario > 3000.0 && salario <= 8000.0) {
			porcentagem = 10;
			aumento = salario * porcentagem / 100;
			novoSal = salario + aumento;
		}
		else {
			porcentagem = 5;
			aumento = salario * porcentagem / 100;
			novoSal = salario + aumento;
		}
		
		System.out.printf("Novo salário = R$ %.2f%n", novoSal);
		System.out.printf("Aumento = R$ %.2f%n", aumento);
		System.out.printf("Porcentagem = %d ", porcentagem);
		
		sc.close();

	}

}
