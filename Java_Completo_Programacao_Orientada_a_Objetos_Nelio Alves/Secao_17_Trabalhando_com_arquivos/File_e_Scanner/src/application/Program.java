package application;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {

		//S�o duas barras invertidas para indicar que realmente � uma barra invertida,
		//Para n�o ser confundido como um \n por exemplo.
		File file = new File("c:\\temp\\in.txt");
		Scanner sc = null;
		try {
			//Ao inves de system.in o scanner agora est� recebendo o file/arquivo, que no caso � o .txt
			sc = new Scanner(file);
			//Esse while � para testar se ainda existe uma linha no arquivo,
			//Se existir vai imprimir na tela.
			while (sc.hasNextLine()) {
				System.out.println(sc.nextLine());
			}

		}
		//Bloco catch para tratar uma possivel excecao do tipo IOException
		catch (IOException e) {
			System.out.println("Error: " + e.getMessage());
		}
		//� uma boa pratica encerrar o recurso com o bloco finally, se der algum erro no try, o scanner n�o vai ser fechado,
		//Com o finally ele vai ser fechado independente se o try deu certo ou n�o.
		finally {
			//Se ocorrer um erro na instancia��o do Scanner vai ocorrer u null.exception, ent�o se faz um if, se for diferente de nulo.
			if (sc != null) {
				sc.close();
			}
		}

	}

}
