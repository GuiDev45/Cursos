package application;

import java.util.InputMismatchException;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {

			method1();
			System.out.println("End of program");
		}

	public static void method1() {
			System.out.println("***METHOD1 START***");
			method2();
			System.out.println("***METHOD1 END***");
		}

	public static void method2() {
			System.out.println("***METHOD2 START***");
			Scanner sc = new Scanner(System.in);
			
			try {
				String[] vect = sc.nextLine().split(" ");
				int position = sc.nextInt();
				System.out.println(vect[position]);
			} 
			catch (ArrayIndexOutOfBoundsException e) {
				System.out.println("Invalid position!");
				//O printStackTrace vai imprimir o rastreamento da stack,
				//Ao digitar uma posição errada vai dar essa execeção.
				//java.lang.ArrayIndexOutOfBoundsException: Index 5 out of bounds for length 3
				//at application.Program.method2(Program.java:27)
				//at application.Program.method1(Program.java:16)
				//at application.Program.main(Program.java:10)
				//Em resumo ele vai mostrar toda chamada de metodos que acarretou a exceção,
				//Isso ajuda a detectar o que está acontecendo e o caminho que levor a dar a exceção.
				e.printStackTrace();
				sc.next();
			} 
			catch (InputMismatchException e) {
				System.out.println("Input error");
			}
			sc.close();
			System.out.println("***METHOD2 END***");
			
		}
	
}
