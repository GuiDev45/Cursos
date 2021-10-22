package application;

import entities.Account;
import entities.BusinessAccount;
import entities.SavingsAccount;

public class Program {

	public static void main(String[] args) {

		//Realizou o valor de saque/withdraw no valor de 200.0 + a taxa de 5.0
		Account acc1 = new Account(1001, "Alex", 1000.0);
		acc1.withdraw(200.0);
		System.out.println(acc1.getBalance());
		
		//Realizou o valor de saque/withdraw no valor de 200.0 e pela sobreposição/Override da classe, não vai ser descontada a taxa de 5.0
		Account acc2 = new SavingsAccount(1002, "Maria", 1000.0, 0.01);
		acc2.withdraw(200.0);
		System.out.println(acc2.getBalance());
		
		//Realizou o valor de saque/withdraw no valor de 200.0, vai ser descontado a taxa de 5.0 que é a lógica da classe Account,
		//E depois vai ser descontado + 2.0
		Account acc3 = new BusinessAccount(1003, "Bob", 1000.0, 500.0);
		acc3.withdraw(200.0);
		System.out.println(acc3.getBalance());
		
	}

}
