package model.entities;

//RunTimeException � um tipo de exce��o que o compilador n�o te obriga a tratar.
//Exception � um tipo de exce��o que o compilador te obriga a tratar.
public class DomainException extends RuntimeException{
	private static final long serialVersionUID = 1L;

	public DomainException(String msg) {
		super(msg);
	}
}
