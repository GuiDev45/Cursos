package application;

import java.io.File;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Enter a folder path: ");
		String strPath = sc.nextLine();
		
		File path = new File(strPath);
		
		//Pega o caminho e também o nome do arquivo.
		System.out.println("getPath: " + path.getPath());
		
		//Pega somente o caminho.
		System.out.println("getParent: " + path.getParent());
		
		//Pega somente pelo nome do arquivo.
		System.out.println("getName: " + path.getName());
		
		sc.close();
		
	}
}
