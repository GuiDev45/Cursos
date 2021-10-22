package application;

import java.io.File;
import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("Enter a folder path: ");
		String strPath = sc.nextLine();
		
		File path = new File(strPath);
		
		//Essa fun��o isDirectory ela lista somente o que for diretorio/ou pastas.
		File[] folders = path.listFiles(File::isDirectory);
		System.out.println("FOLDERS:");
		
		for (File folder : folders) {
			System.out.println(folder);
		}
		
		//Essa fun��o isFile ela lista somente os arquivos, n�o pastas.
		File[] files = path.listFiles(File::isFile);
		System.out.println("FILES:");
		for (File file : files) {
			System.out.println(file);
		}
		
		//Cria uma subpasta, a partir da pasta temp no caso.
		//� boolean porque a variavel success vai indicar se a opera��o deu certo ou n�o.
		boolean success = new File(strPath + "\\subdir").mkdir();
		System.out.println("Directory created successfully: " + success);
		
		sc.close();
		
	}
}
