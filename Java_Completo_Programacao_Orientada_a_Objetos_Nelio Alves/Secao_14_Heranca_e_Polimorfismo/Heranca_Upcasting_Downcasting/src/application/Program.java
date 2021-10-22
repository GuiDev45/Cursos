package application;

import entities.Account;
import entities.BusinessAccount;
import entities.SavingsAccount;

public class Program {

	public static void main(String[] args) {

		Account acc = new Account(1001, "Alex", 0.0);
		BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
		
		//UPCASTING
		
		//É pegar um objeto do tipo BusinessAccount e converter para um objeto do tipo Account.
		//Sendo um objeto da subclasse atribuito para superclasse não ocorre nenhum erro, é uma relação é 1,
		//Uma BusinessAccount É uma Account.
		Account acc1 = bacc;
		Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
		Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
		
		//DOWNCASTING
		
		BusinessAccount acc4 = (BusinessAccount)acc2;
		acc4.loan(100.0);
		//Para converter de Account para BusinessAccount é necessário fazer o casting, pelo fato da conversão não ser natural.
		//BusinessAccount acc5 = (BusinessAccount)acc3;
		
		//A variavel acc3 foi instanciada como SavingsAccount, SavingsAccount É uma Account mas não é uma BusinessAccount,
		//Ambas são subclasses da Account, na hora de compilar se for apenas o casting, vai dar erro.
		
		//Se o que tiver na variável acc3 for um objeto que seja instância de BusinessAccount ai sim pode fazer o casting.
		if (acc3 instanceof BusinessAccount) {
			BusinessAccount acc5 = (BusinessAccount)acc3;
			acc5.loan(200.0);
			System.out.println("Loan!");
		}
		
		//Se acc3 é instância de SavingsAccount, se ele for acc5 recebe o casting de SavingsAccount da variável acc3.
		if (acc3 instanceof SavingsAccount) {
			SavingsAccount acc5 = (SavingsAccount)acc3;
			acc5.updateBalance();
			System.out.println("Update!");
		}
		
		//Apenas para não ficar acusando erro.
		System.out.println(acc);
		System.out.println(acc1);
		
	}

}
