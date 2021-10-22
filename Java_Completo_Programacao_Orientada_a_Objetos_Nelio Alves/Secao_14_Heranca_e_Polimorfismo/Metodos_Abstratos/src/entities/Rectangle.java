package entities;

import entities.enums.Color;

public class Rectangle extends Shape{

	private Double width;
	private Double height;
	
	public Rectangle() {
		super();
	}

	public Rectangle(Color color, Double width, Double height) {
		super(color);
		this.width = width;
		this.height = height;
	}
	
	public Double getWidth() {
		return width;
	}

	public void setWidth(Double width) {
		this.width = width;
	}

	public Double getHeight() {
		return height;
	}

	public void setHeight(Double height) {
		this.height = height;
	}

	//Herdando o metodo da classe abstrata Shape/forma,
	//E adicionando o pr�prio calculo da area do retangulo.
	@Override
	public double area() {
		return width * height;
	}
	
}
