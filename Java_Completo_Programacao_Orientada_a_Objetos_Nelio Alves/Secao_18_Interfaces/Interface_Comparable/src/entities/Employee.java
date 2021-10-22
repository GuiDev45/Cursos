package entities;

//Para tornar uma classe Comparable é preciso implementar a interface Comparable, para ser ordenado pelo metodo .sort
public class Employee implements Comparable<Employee> {

	private String name;
	private Double salary;
	
	public Employee(String name, Double salary) {
		this.name = name;
		this.salary = salary;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Double getSalary() {
		return salary;
	}

	public void setSalary(Double salary) {
		this.salary = salary;
	}

	@Override
	//O metodo compareTo ele é obrigatorio quando se implementa o Comparable,
	//Esse metodo serve para comparar um objeto com outro.
	public int compareTo(Employee other) {
		//Vai retornar o nome do funcionario com o outro nome de outro funcionario na lista,
		//Assim ordenando os nomes.
		return name.compareTo(other.getName());
	}
	
	//Se fosse comparar com o salario seria está forma, 
	//Ordenando de forma crescente, se quiser em ordem decrescente é só colocar o sinal de - em salary, -salary.compareTo.....
	
	//public int compareTo(Employee other) {
		//return salary.compareTo(other.getSalary());
	//}
	
}
