package model.entities;

//RunTimeException é um tipo de exceção que o compilador não te obriga a tratar.
//Exception é um tipo de exceção que o compilador te obriga a tratar.
public class DomainException extends RuntimeException{
	private static final long serialVersionUID = 1L;

	public DomainException(String msg) {
		super(msg);
	}
}
