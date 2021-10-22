package application;

import java.util.HashSet;
import java.util.Set;

public class Program {
	
	public static void main(String[] args) {
		
		//Imprime a lista, � mais forma r�pida por�m n�o ordenada de mostrar a lista.
		Set<String> set = new HashSet<>();
		
		//Imprime a lista, � mais lenta que o HashSet por�m ele ordena os dados.
		//Set<String> set = new TreeSet<>();
		
		//Ele mantem a ordem em que os elementos foram inseridos.
		//Set<String> set = new LinkedHashSet<>();
		
		set.add("Tv");
		set.add("Notebook");
		set.add("Tablet");
		
		//Remove o elemento Tablet
		set.remove("Tablet");
		
		//Ele remove apenas os objetos que satisfazem algum predicado,
		//Nessa situa��o vai remover todo conte�do que tiver 3 caracteres.
		set.removeIf(x -> x.length() >= 3);
		//Nessa situa��o vai remover todo conte�do que tiver a primeira letra igual a T.
		set.removeIf(x -> x.charAt(0) == 'T');
		
		//Pergunta se nessa lista h� um elemento Notebook
		System.out.println(set.contains("Notebook"));
		
		for (String p : set) {
			System.out.println(p);
		}
		
	}
}
