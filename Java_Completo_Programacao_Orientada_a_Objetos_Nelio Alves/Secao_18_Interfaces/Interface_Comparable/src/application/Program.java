package application;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import entities.Employee;

public class Program {

	public static void main(String[] args) {
		
		List<Employee> list = new ArrayList<>();
		String path = "C:\\temp\\in.txt";
		
		try (BufferedReader br = new BufferedReader(new FileReader(path))) {
			
			String employeeCsv = br.readLine();
			while (employeeCsv != null) {
				//Cria um vetor onde cada posi��o vai ser um campo, a posi��o 0 vai ser o nome e a posi��o 1 vai ser o salario.
				String[] fields = employeeCsv.split(",");
				//Precisa converter o salario para Double dessa forma,
				//Dessa forma est� instanciando o funcionario e o salario.
				list.add(new Employee(fields[0], Double.parseDouble(fields[1])));
				employeeCsv = br.readLine();
			}
			//� uma opera��o padr�o, uma forma de ordenar uma cole��o
			Collections.sort(list);
			for (Employee emp : list) {
				System.out.println(emp.getName() + ", " + emp.getSalary());
			}
			
		    } catch (IOException e) {
			System.out.println("Error: " + e.getMessage());
		}
	}
}
