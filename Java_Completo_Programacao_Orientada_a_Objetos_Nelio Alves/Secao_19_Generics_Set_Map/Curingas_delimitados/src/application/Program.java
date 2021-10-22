package application;

import java.util.ArrayList;
import java.util.List;

import entities.Circle;
import entities.Rectangle;
import entities.Shape;

public class Program {

	public static void main(String[] args) {
		
		List<Shape> myShapes = new ArrayList<>();
		myShapes.add(new Rectangle(3.0, 2.0));
		myShapes.add(new Circle(2.0));
		
		List<Circle> myCircles = new ArrayList<>();
		myCircles.add(new Circle(2.0));
		myCircles.add(new Circle(3.0));
		
		System.out.println("Total area: " + totalArea(myCircles));
	}
	
	//Está dizendo que minha lista pode ser um Shape, ou que qualquer tipo que seja um subtipo<?> de Shape.
	//Porém não é possivel adicionar na lista, list.add porque, 
	//Ex o compilador diz que pode ser um tipo Shape porém incompativel com o Rectangle, 
	//Se minha lista fosse de Circle não poderia inserir Rectangle, por isso não aceita o list.add
	public static double totalArea(List<? extends Shape> list) {
		double sum = 0.0;
		for (Shape s : list) {
			sum += s.area();
		}
		return sum;
	}
}
