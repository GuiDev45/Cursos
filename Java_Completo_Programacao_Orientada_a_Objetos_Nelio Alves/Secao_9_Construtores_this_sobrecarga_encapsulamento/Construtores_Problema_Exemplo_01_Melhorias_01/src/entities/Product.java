package entities;

public class Product {

	public String name;
	public double price;
	public int quantity;

	/*
	 * Construtor
	 * •É uma operação especial da classe, que executa no momento da instanciação do objeto 
	 * •Usos comuns: 
	 * •Iniciar valores dos atributos 
	 * •Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação (injeção de dependência) 
	 * •Se um construtor customizado não for especificado, a classe disponibiliza o construtor padrão: Product p = new Product(); 
	 * •É possível especificar mais de um construtor na mesma classe (sobrecarga)
	 */
	
	/* 
	 * Palavra this
     * •É uma referência para o próprio objeto
     * •Usos comuns:
     * •Diferenciar atributos de variáveis locais
     * •Passar o próprio objeto como argumento na chamada de um método ou construtor
     */
	
	/*
	 * Sobrecarga
	 * é possível também incluir um construtor padrão
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
	 * construtor opcional, recebe apenas nome e preço do produto.
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
