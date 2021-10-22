package application;

import java.util.HashSet;
import java.util.Set;

public class Program {
	
	public static void main(String[] args) {
		
		//Imprime a lista, é mais forma rápida porém não ordenada de mostrar a lista.
		Set<String> set = new HashSet<>();
		
		//Imprime a lista, é mais lenta que o HashSet porém ele ordena os dados.
		//Set<String> set = new TreeSet<>();
		
		//Ele mantem a ordem em que os elementos foram inseridos.
		//Set<String> set = new LinkedHashSet<>();
		
		set.add("Tv");
		set.add("Notebook");
		set.add("Tablet");
		
		//Remove o elemento Tablet
		set.remove("Tablet");
		
		//Ele remove apenas os objetos que satisfazem algum predicado,
		//Nessa situação vai remover todo conteúdo que tiver 3 caracteres.
		set.removeIf(x -> x.length() >= 3);
		//Nessa situação vai remover todo conteúdo que tiver a primeira letra igual a T.
		set.removeIf(x -> x.charAt(0) == 'T');
		
		//Pergunta se nessa lista há um elemento Notebook
		System.out.println(set.contains("Notebook"));
		
		for (String p : set) {
			System.out.println(p);
		}
		
	}
}
