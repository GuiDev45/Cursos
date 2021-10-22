package services;

import java.util.ArrayList;
import java.util.List;

//Para aproveitar o reuso da classe, se usa o tipo generics T, podendo assim na classe program trocar Integer pra String ou pra outro tipo,
//Que o reuso da classe que está com o tipo de lista generic vai aceitar,
//Isso impede que seja necessaria a criação de outra classe, só pelo tipo diferente da lista.
public class PrintService<T> {

	private List<T> list = new ArrayList<>();

	public void addValue(T value) {
		list.add(value);
	}

	public T first() {
		if (list.isEmpty()) {
			throw new IllegalStateException("List is empty");
		}
		return list.get(0);
	}

	public void print() {
		System.out.print("[");
		if (!list.isEmpty()) {
			System.out.print(list.get(0));
		}
		for (int i = 1; i < list.size(); i++) {
			System.out.print(", " + list.get(i));
		}
		System.out.println("]");
	}
}
