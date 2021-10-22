package application;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {

		//Vai abrir um arquivo de texto, e mostrar esse conteúdo na tela.
		//Variável do tipo File, na instanciação desse objeto se passa o caminho do arquivo.
		File file = new File("C:\\temp\\in.txt");
		//A classe Scanner também serve para apontar arquivos, ela pode ler a partir de arquivos, não somente console.
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
		//Independente se de certo ou não, é preciso fechar esse Scanner para evitar que o arquivo fique aberto, 
		//E dessa forma se fecha o arquivo, se a variável sc for diferente de nulo, o sc fecha.
		finally {
			if (sc != null) {
				sc.close();
			}
		}
	}
}
