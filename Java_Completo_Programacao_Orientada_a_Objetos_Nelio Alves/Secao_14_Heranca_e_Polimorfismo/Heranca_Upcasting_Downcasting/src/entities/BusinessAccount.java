package entities;

public class BusinessAccount extends Account{
//Com isso estou definindo que essa classe vai herdar o comportamento da classe Account.
//Tendo assim todos os atributos e métodos da classe Account.
	
	private Double loanLimit;
	
	//No contrutor padrão é possivel chamar o super().
	//Pode ser que tenha alguma lógica no construtor padrão da classe Account, e se precisar repetir a lógica se chama o super().
	//É só pra resguardar, caso no futuro for feito alguma lógica no construtor padrão da classe Account.
	public BusinessAccount() {
		super();
	}

	//Construtor com os quatros argumentos, não precisando repetir os argumentos.
	//é só chamar o construtor da super classe que é a classe Account.
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
