package entities;

public class Account {

	private int accNumber;
	private String holder;
	private double balance;
	
	public Account() {
	}
	
	public Account(int accNumber, String holder) {
		this.accNumber = accNumber;
		this.holder = holder;
	}
	
	public Account(int accNumber, String holder, double initialDeposit) {
		this.accNumber = accNumber;
		this.holder = holder;
		deposit(initialDeposit);
	}
	
	public int getAccNumber() {
		return accNumber;
	}
	
	public String getHolder() {
		return holder;
	}
	
	public void setHolder(String holder) {
		this.holder = holder;
	}
	
	public double getBalance() {
		return balance;
	}
	
	public void deposit(double amount) {
		this.balance += amount;
	}
	
	public void withdraw(double amount) {
		this.balance -= amount + 5.0;
	}
	
	public String toString() {
		return "Account " 
	           + accNumber 
	           + ", Holder: " 
	           + holder 
	           + ", Balance: $ " 
	           + String.format("%.2f", balance);
	}
	
}
