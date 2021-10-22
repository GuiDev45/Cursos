package application;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {

		Scanner sc = new Scanner(System.in);
		
		//Esse bloco de código pode ocorrer exceções, então ele fica dentro do try.
		try {
			//Insere um nome no vetor e com o position mostra a posição a onde nome está.
			String[] vect = sc.nextLine().split(" ");
			int position = sc.nextInt();
			System.out.println(vect[position]);
		}
		//No bloco catch é delcarada a possível exceção caso ocorra, ela vai ser capturada aqui,
		//Nesse casso é uma posição invalida e continuar a execução do programa até a saida End of program.
		catch (ArrayIndexOutOfBoundsException e) {
			System.out.println("Invalid position!");
		}
		//Nesse bloco catch se a entrada do position for diferente de um int, a exceção é capturada.
		catch (InputMismatchException e) {
			System.out.println("Input error");
		}
		
		System.out.println("End of program");
		
		sc.close();

	}

}
