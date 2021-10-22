package application;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {

		//Vai abrir um arquivo de texto, e mostrar esse conte�do na tela.
		//Vari�vel do tipo File, na instancia��o desse objeto se passa o caminho do arquivo.
		File file = new File("C:\\temp\\in.txt");
		//A classe Scanner tamb�m serve para apontar arquivos, ela pode ler a partir de arquivos, n�o somente console.
		Scanner sc = null;
		try {
			sc = new Scanner(file);
			while (sc.hasNextLine()) {
				System.out.println(sc.nextLine());
			}
		} 
		catch (IOException e) {
			System.out.println("Error opening file: " + e.getMessage());
		}
		//Independente se de certo ou n�o, � preciso fechar esse Scanner para evitar que o arquivo fique aberto, 
		//E dessa forma se fecha o arquivo, se a vari�vel sc for diferente de nulo, o sc fecha.
		finally {
			if (sc != null) {
				sc.close();
			}
		}
	}
}
