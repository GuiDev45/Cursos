package entities;

import entities.enums.Color;

public abstract class Shape {
//Questionamento, como calcular a area de uma forma sem saber a forma, n�o � poss�vel,
//Por isso foi feito o metodo abstrato, pra poder passar esse metodo para calcular a area tanto do Rectangle como do Circle.
//Com isso � possivel fazer o polimorfismo apartir da classe Shape/forma.
//Se a classe possuir apenas um metodo abstrato, ent�o a classe tem que ser abstract.
	
	private Color color;

	public Shape() {
	}
	
	public Shape(Color color) {
		this.color = color;
	}
	
	public Color getColor() {
		return color;
	}

	public void setColor(Color color) {
		this.color = color;
	}
	
	//Declara��o do metodo abstract.
	public abstract double area();
	
}
