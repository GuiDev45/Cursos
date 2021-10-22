package entities;

import entities.enums.Color;

public class Circle extends Shape{

	private Double radius;
	
	public Circle() {
		super();
	}
	
	public Circle(Color color, Double radius) {
		super(color);
		this.radius = radius;
	}
	
	public Double getRadius() {
		return radius;
	}

	public void setRadius(Double radius) {
		this.radius = radius;
	}

	//Herdando o metodo da classe abstrata Shape/forma,
	//E adicionando o próprio calculo da area do circulo.
	@Override
	public double area() {
		return Math.PI * radius * radius;
	}

}
