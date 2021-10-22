package application;

import entities.Account;
import entities.BusinessAccount;
import entities.SavingsAccount;

public class Program {

	public static void main(String[] args) {

		Account acc = new Account(1001, "Alex", 0.0);
		BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
		
		//UPCASTING
		
		//� pegar um objeto do tipo BusinessAccount e converter para um objeto do tipo Account.
		//Sendo um objeto da subclasse atribuito para superclasse n�o ocorre nenhum erro, � uma rela��o � 1,
		//Uma BusinessAccount � uma Account.
		Account acc1 = bacc;
		Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
		Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
		
		//DOWNCASTING
		
		BusinessAccount acc4 = (BusinessAccount)acc2;
		acc4.loan(100.0);
		//Para converter de Account para BusinessAccount � necess�rio fazer o casting, pelo fato da convers�o n�o ser natural.
		//BusinessAccount acc5 = (BusinessAccount)acc3;
		
		//A variavel acc3 foi instanciada como SavingsAccount, SavingsAccount � uma Account mas n�o � uma BusinessAccount,
		//Ambas s�o subclasses da Account, na hora de compilar se for apenas o casting, vai dar erro.
		
		//Se o que tiver na vari�vel acc3 for um objeto que seja inst�ncia de BusinessAccount ai sim pode fazer o casting.
		if (acc3 instanceof BusinessAccount) {
			BusinessAccount acc5 = (BusinessAccount)acc3;
			acc5.loan(200.0);
			System.out.println("Loan!");
		}
		
		//Se acc3 � inst�ncia de SavingsAccount, se ele for acc5 recebe o casting de SavingsAccount da vari�vel acc3.
		if (acc3 instanceof SavingsAccount) {
			SavingsAccount acc5 = (SavingsAccount)acc3;
			acc5.updateBalance();
			System.out.println("Update!");
		}
		
		//Apenas para n�o ficar acusando erro.
		System.out.println(acc);
		System.out.println(acc1);
		
	}

}
