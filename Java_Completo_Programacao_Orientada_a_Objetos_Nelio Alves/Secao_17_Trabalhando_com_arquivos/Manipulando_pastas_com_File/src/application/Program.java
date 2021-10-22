package application;

import java.io.File;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Enter a folder path: ");
		String strPath = sc.nextLine();
		
		File path = new File(strPath);
		
		//Essa função isDirectory ela lista somente o que for diretorio/ou pastas.
		File[] folders = path.listFiles(File::isDirectory);
		System.out.println("FOLDERS:");
		
		for (File folder : folders) {
			System.out.println(folder);
		}
		
		//Essa função isFile ela lista somente os arquivos, não pastas.
		File[] files = path.listFiles(File::isFile);
		System.out.println("FILES:");
		for (File file : files) {
			System.out.println(file);
		}
		
		//Cria uma subpasta, a partir da pasta temp no caso.
		//É boolean porque a variavel success vai indicar se a operação deu certo ou não.
		boolean success = new File(strPath + "\\subdir").mkdir();
		System.out.println("Directory created successfully: " + success);
		
		sc.close();
		
	}
}
