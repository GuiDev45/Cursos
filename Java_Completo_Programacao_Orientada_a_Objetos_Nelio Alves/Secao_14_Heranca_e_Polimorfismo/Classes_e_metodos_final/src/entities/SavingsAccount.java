package entities;

public final class SavingsAccount extends Account{
//O final evita que a classe seja herdada por outra classe.
	
	private Double interestRate;
	
	public SavingsAccount() {
		super();
	}

	public SavingsAccount(Integer number, String holder, Double balance, Double interestRate) {
		super(number, holder, balance);
		this.interestRate = interestRate;
	}

	public Double getInterestRate() {
		return interestRate;
	}

	public void setInterestRate(Double interestRate) {
		this.interestRate = interestRate;
	}
	
	public void updateBalance() {
		balance += balance + interestRate;
	}
	
	//final em um método significa que não pode ser sobreposto.
	//*Esse método já é sobreposto da classe Account, então sobrepor novamente em outra subclasse pode gerar inconsistências.
	@Override
	public final void withdraw(double amount) {
		balance -= amount;
	}
	
}
