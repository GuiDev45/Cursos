package entities;

public class Product {

	/* Encapsulamento
	 * Regra geral b�sica:
     * �Um objeto N�O deve expor nenhum atributo (modificador de acesso private)
     * �Os atributos devem ser acessados por meio de m�todos get e set
     */
	
	//private: o membro s� pode ser acessado na pr�pria classe
	private String name;
	private double price;
	private int quantity;

	public Product() {
	}

	public Product(String name, double price, int quantity) {
		this.name = name;
		this.price = price;
		this.quantity = quantity;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public double getPrice() {
		return price;
	}

	public void setPrice(double price) {
		this.price = price;
	}

	/*
	 * O quantity n�o recebeu um setQuantity pois a quantidade s� pode ser alterada quando houver uma entrada ou uma saida do estoque.
	 * Que fica na responsabilidade do addProducts e removeProducts 
	 * Isso � uma regra de neg�cio que protege a integridade do objeto produto
	 */
	public int getQuantity() {
		return quantity;
	}

	public double totalValueInStock() {
		return price * quantity;
	}

	//Repetindo, s� pode mudar por meio das opera��es.
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
