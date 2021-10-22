package application;

import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.Scanner;

import entities.Employee;
import entities.OutsourcedEmployee;

public class Program {

	public static void main(String[] args) {

		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		List<Employee> list = new ArrayList<>();
		
		System.out.print("Enter the number of employees: ");
		int n = sc.nextInt();
		
		for (int i = 1; i <= n; i++) {
			System.out.println("Employee #" + i + " data:");
			System.out.print("Outsourced (y/n)? ");
			char ch = sc.next().charAt(0);
			System.out.print("Name: ");
			sc.nextLine();
			String name = sc.nextLine();
			System.out.print("Hours: ");
			int hours = sc.nextInt();
			System.out.print("Value per hour: ");
			double valuePerHour = sc.nextDouble();
			
			//Se o funcionário for terceirizado então emp recebe OutsourcedEmployee, casou não for terceirizado emp recebe Employee.
			//Após a decisão é adicionado ao list.
			if (ch == 'y') {
				System.out.print("Aditional charge: ");
				double additionalCharge = sc.nextDouble();
				Employee emp = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
				list.add(emp);
				//Pode também ser adicionado a list dessa forma.
				//list.add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
			}
			else {
				Employee emp = new Employee(name, hours, valuePerHour);
				list.add(emp);
				//Pode também ser adicionado a list dessa forma.
				//list.add(new Employee(name, hours, valuePerHour);
			}
		}
		
		System.out.println();
		System.out.println("PAYMENTS:");
		//Percorrendo a list e dizendo para imprimir o nome e o pagamento de cada funcionário.
		//Para cada Employee emp nessa list ......
		for (Employee emp : list) {
			System.out.println(emp.getName() + " - $ " + String.format("%.2f", emp.payment()));
		}
		
		sc.close();

	}

}
