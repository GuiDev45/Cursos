package application;

import java.util.Locale;
import java.util.Scanner;

import entities.Account;

public class Program {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		Account acc = new Account();

		System.out.print("Enter account number: ");
		int accNumber = sc.nextInt();
		System.out.print("Enter account holder: ");
		sc.nextLine();
		String holder = sc.nextLine();
		System.out.print("Is there an initial deposit (y/n)? ");
		char initial = sc.next().charAt(0);

		if (initial == 'y') {
			System.out.print("Enter initial deposit value: ");
			double initialDeposit = sc.nextDouble();
			acc = new Account(accNumber, holder, initialDeposit);
		}
		else {
			acc = new Account(accNumber, holder);
		}

		System.out.println();
		System.out.println("Account data:");
		System.out.print(acc);
		System.out.println();
		
		System.out.println();
		System.out.print("Enter a deposit value: ");
		double depositValue = sc.nextDouble();
		acc.deposit(depositValue);
		System.out.println("Updated account data:");
		System.out.println(acc);
		
		System.out.println();
		System.out.print("Enter a withdraw value: ");
		double withdrawValue = sc.nextDouble();
		acc.withdraw(withdrawValue);
		System.out.println("Updated account data:");
		System.out.println(acc);
		
		sc.close();

	}

}
