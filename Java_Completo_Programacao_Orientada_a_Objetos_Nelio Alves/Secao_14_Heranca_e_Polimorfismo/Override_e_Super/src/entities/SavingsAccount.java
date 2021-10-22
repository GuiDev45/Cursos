package entities;

public class SavingsAccount extends Account{

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
	
	//Na classe Account tem a opera��o normal que desconta 5.0 do saque.
	//E para sobrescrever essa opera��o sem descontar os 5.0, � colocado o Override, ele tamb�m indica se tem algo errado na sintaxe.
	//Isso � uma sobreposi��o de m�todo.
	@Override
	public void withdraw(double amount) {
		balance -= amount;
	}
	
}
