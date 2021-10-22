package application;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		//Esse bloco de c�digo pode ocorrer exce��es, ent�o ele fica dentro do try.
		try {
			//Insere um nome no vetor e com o position mostra a posi��o a onde nome est�.
			String[] vect = sc.nextLine().split(" ");
			int position = sc.nextInt();
			System.out.println(vect[position]);
		}
		//No bloco catch � delcarada a poss�vel exce��o caso ocorra, ela vai ser capturada aqui,
		//Nesse casso � uma posi��o invalida e continuar a execu��o do programa at� a saida End of program.
		catch (ArrayIndexOutOfBoundsException e) {
			System.out.println("Invalid position!");
		}
		//Nesse bloco catch se a entrada do position for diferente de um int, a exce��o � capturada.
		catch (InputMismatchException e) {
			System.out.println("Input error");
		}
		
		System.out.println("End of program");
		
		sc.close();

	}

}
