package application;

import java.util.ArrayList;
import java.util.List;
import java.util.Locale;

import entities.Account;
import entities.BusinessAccount;
import entities.SavingsAccount;

public class Program {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		
		//Não da pra instanciar a classe do tipo Account porque ela é abstrata
		/*Account acc1 = new Account(1001, "Alex", 1000.0);
		acc1.withdraw(200.0);
		System.out.println(acc1.getBalance());*/
		
		//Com a classe abstrata é possivel colocar por exemplo todos os tipos de conta em uma mesma coleção,
		//Fica mais facil implementar esse tipo de operação com a classe génerica.
		List<Account> list = new ArrayList<>();
		
		//O tipo da lista é um tipo generico, e com isso da pra inserir tanto objeto da BusinessAccount como da SavingsAccount.
		list.add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
		list.add(new BusinessAccount(1002, "Maria", 1000.0, 400.0));
		list.add(new SavingsAccount(1004, "Bob", 300.00, 0.01));
		list.add(new BusinessAccount(1005, "Anna", 500.0, 500.0));
		
		//Supondo que precise totalizar o saldo de todas as contas, sendo elas SavingsAccount ou BusinessAccount.
		//Dessa forma a soma é realizada independente do tipo de conta.
		double sum = 0.0;
		for (Account acc : list) {
			sum += acc.getBalance();
		}
		
		System.out.printf("Total balance: %.2f%n", sum);
		
		//Exemplo de um depósito de 10.0 em cada conta
		for (Account acc : list) {
			acc.deposit(10.0);
		}
		
		//Imprimindo o balance atualizado de cada conta.
		for (Account acc : list) {
			System.out.printf("Updated balance for account %d: %.2f%n", acc.getNumber(), acc.getBalance());
		}

	}

}
