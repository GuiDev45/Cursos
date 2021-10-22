package entities;

public class BusinessAccount extends Account{
	
	private Double loanLimit;
	
	public BusinessAccount() {
		super();
	}

	public BusinessAccount(Integer number, String holder, Double balance, Double loanLimit) {
		super(number, holder, balance);
		this.loanLimit = loanLimit;
	}

	public Double getLoanLimit() {
		return loanLimit;
	}

	public void setLoanLimit(Double loanLimit) {
		this.loanLimit = loanLimit;
	}
	
	public void loan(double amount) {
		if (amount <= loanLimit) {
			balance += amount - 10.0;
		}
	}
	
	//A regra de saque em BusinessAccount vai ser a mesma operação da classe Account porém acrescentando um desconto de 2.0
	//Para isso é só chamar a operação withdraw utilizando o super, super.withdraw(amount); e depois foi acrescentado o valor de 2.0.
	@Override
	public void withdraw(double amount) {
		super.withdraw(amount);
		balance -= 2.0;
	}
	
}
