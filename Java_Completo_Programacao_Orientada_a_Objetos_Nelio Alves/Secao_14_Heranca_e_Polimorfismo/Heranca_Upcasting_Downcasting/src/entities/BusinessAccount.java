package entities;

public class BusinessAccount extends Account{
//Com isso estou definindo que essa classe vai herdar o comportamento da classe Account.
//Tendo assim todos os atributos e m�todos da classe Account.
	
	private Double loanLimit;
	
	//No contrutor padr�o � possivel chamar o super().
	//Pode ser que tenha alguma l�gica no construtor padr�o da classe Account, e se precisar repetir a l�gica se chama o super().
	//� s� pra resguardar, caso no futuro for feito alguma l�gica no construtor padr�o da classe Account.
	public BusinessAccount() {
		super();
	}

	//Construtor com os quatros argumentos, n�o precisando repetir os argumentos.
	//� s� chamar o construtor da super classe que � a classe Account.
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
	
}
