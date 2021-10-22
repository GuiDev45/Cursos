package entities;

public class Product {

	public String name;
	public double price;
	public int quantity;

	/*
	 * Construtor
	 * �� uma opera��o especial da classe, que executa no momento da instancia��o do objeto 
	 * �Usos comuns: 
	 * �Iniciar valores dos atributos 
	 * �Permitir ou obrigar que o objeto receba dados / depend�ncias no momento de sua instancia��o (inje��o de depend�ncia) 
	 * �Se um construtor customizado n�o for especificado, a classe disponibiliza o construtor padr�o: Product p = new Product(); 
	 * �� poss�vel especificar mais de um construtor na mesma classe (sobrecarga)
	 */
	
	/* 
	 * Palavra this
     * �� uma refer�ncia para o pr�prio objeto
     * �Usos comuns:
     * �Diferenciar atributos de vari�veis locais
     * �Passar o pr�prio objeto como argumento na chamada de um m�todo ou construtor
     */
	
	/*
	 * Sobrecarga
	 * � poss�vel tamb�m incluir um construtor padr�o
	 */
	public Product() {
	}
	
	public Product(String name, double price, int quantity) {
		this.name = name;
		this.price = price;
		this.quantity = quantity;
	}

	/*
	 * Sobrecarga
	 * construtor opcional, recebe apenas nome e pre�o do produto.
	 */
	public Product(String name, double price) {
		this.name = name;
		this.price = price;
	}
	
	public double totalValueInStock() {
		return price * quantity;
	}

	public void addProducts(int quantity) {
		this.quantity += quantity;
	}

	public void removeProducts(int quantity) {
		this.quantity -= quantity;
	}

	public String toString() {
		return name 
				+ ", $ " 
				+ String.format("%.2f", price) 
				+ ", " 
				+ quantity 
				+ " units, Total: $ "
				+ String.format("%.2f", totalValueInStock());
	}
}
