import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Nome: ");
		String nome = sc.nextLine();
		
		System.out.print("Valor por hora: ");
		double valorHora = sc.nextDouble();
		
		System.out.print("Horas trabalhadas: ");
		int horaTrab = sc.nextInt();
		
		double pagamento = horaTrab * valorHora;
		
		System.out.printf("O pagamento para %s deve ser %.2f", nome, pagamento);
		
		sc.close();

	}

}
