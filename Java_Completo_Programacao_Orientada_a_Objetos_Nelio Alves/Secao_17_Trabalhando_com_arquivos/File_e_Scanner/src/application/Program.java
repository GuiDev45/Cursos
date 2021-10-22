package application;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {

		//São duas barras invertidas para indicar que realmente é uma barra invertida,
		//Para não ser confundido como um \n por exemplo.
		File file = new File("c:\\temp\\in.txt");
		Scanner sc = null;
		try {
			//Ao inves de system.in o scanner agora está recebendo o file/arquivo, que no caso é o .txt
			sc = new Scanner(file);
			//Esse while é para testar se ainda existe uma linha no arquivo,
			//Se existir vai imprimir na tela.
			while (sc.hasNextLine()) {
				System.out.println(sc.nextLine());
			}

		}
		//Bloco catch para tratar uma possivel excecao do tipo IOException
		catch (IOException e) {
			System.out.println("Error: " + e.getMessage());
		}
		//É uma boa pratica encerrar o recurso com o bloco finally, se der algum erro no try, o scanner não vai ser fechado,
		//Com o finally ele vai ser fechado independente se o try deu certo ou não.
		finally {
			//Se ocorrer um erro na instanciação do Scanner vai ocorrer u null.exception, então se faz um if, se for diferente de nulo.
			if (sc != null) {
				sc.close();
			}
		}

	}

}
