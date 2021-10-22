package application;

import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

import entities.Shape;
import entities.Rectangle;
import entities.Circle;
import entities.enums.Color;
public class Program {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Enter the number of shapes: ");
		int n = sc.nextInt();
		
		//Como o objetivo é o polimorfismo, então deve ser declarado o tipo de lista generico, o tipo de lista da super classe
		//Que no caso é o Shape, dessa forma essa lista vai aceitar dados de todos os tipos da subclasse.
		List<Shape> list = new ArrayList<>();
		
		for (int i = 1; i <= n; i++) {
			System.out.println("Shape #" + i + " data:");
			System.out.print("Rectangle or Circle (r/c)? ");
			char ch = sc.next().charAt(0);
			System.out.print("Color (BLACK/BLUE/RED): ");
			Color color = Color.valueOf(sc.next());
			
			if (ch == 'r') {
				System.out.print("Width: ");
				double width = sc.nextDouble();
				System.out.print("Height: ");
				double height = sc.nextDouble();
				//Deis de que se instancia os objetos de tipo concreto, será feito o upcasting para Shape, e a lista vai funcionar normalmente.
				list.add(new Rectangle(color, width, height));
			}
			else {
				System.out.print("Radius: ");
				double radius = sc.nextDouble();
				//Deis de que se instancia os objetos de tipo concreto, será feito o upcasting para Shape, e a lista vai funcionar normalmente.
				list.add(new Circle(color, radius));
			}
		}
		
		System.out.println();
		System.out.println("SHAPE AREAS:");
		for (Shape shape : list) {
			//Podendo fazer o polimorfismo como aconteceu com a area.
			System.out.println(String.format("%.2f", shape.area()));
		}
		
		sc.close();

	}

}
