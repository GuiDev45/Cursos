package application;

import java.util.Arrays;
import java.util.Set;
import java.util.TreeSet;

public class Program {
	
	public static void main(String[] args) {
		
		Set<Integer> a = new TreeSet<>(Arrays.asList(0, 2, 4, 5, 6, 8, 10));
		Set<Integer> b = new TreeSet<>(Arrays.asList(5, 6, 7, 8, 9, 10));
		
        //union
		//O conjunto c vai ser uma cópia do conjunto a.
		Set<Integer> c = new TreeSet<>(a);
		//Esta sendo feita a união do conjunto c com o conjunto b.
		c.addAll(b);
		System.out.println(c);
		
		//intersection
		//O conjunto d vai receber uma cópia do conjunto a.
		Set<Integer> d = new TreeSet<>(a);
		//Intersecção - é somentos os elementos que são comuns entre os conjuntos.
		d.retainAll(b);
		System.out.println(d);
		
		//difference
		//Conjunto e vai ser uma cópia do conjunto a.
		Set<Integer> e = new TreeSet<>(a);
		//Vai remover do conjunto e, tudo que for igual ao conjunto b.
		e.removeAll(b);
		System.out.println(e);
		
	}
}
