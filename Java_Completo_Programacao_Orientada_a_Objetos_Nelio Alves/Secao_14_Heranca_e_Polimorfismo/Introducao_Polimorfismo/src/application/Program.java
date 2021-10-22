package application;

import entities.Account;
import entities.SavingsAccount;

public class Program {

	public static void main(String[] args) {

		//Esse métodos possuem implementações diferentes em cada classe.
		
		Account x = new Account(1020, "Alex", 1000.0);
		//Vai apontar para tipos diferentes na memoria, mas as variaveis que vão apontar para esse objeto, são do mesmo tipo.
		Account y = new SavingsAccount(1023, "Maria", 1000.0, 0.01);
		
		//É dessa forma que vai ficar na memoria.
		//X -----> [1020|Alex|1000.0] - vai estar chamando a operação de saque da classe Account.
		//Y -----> [1023|Maria|1000.0|0.01] - vai estar chamando a operação de saque da classe SavingsAccount.
		
		//Ao chamar a variavel x ou y, uma vai ter um comportamento diferente da outra.
		x.withdraw(50.0);
		y.withdraw(50.0);
		
		//Saida do saldo das duas contas.
		System.out.println(x.getBalance());
		System.out.println(y.getBalance());
		
	}

}
