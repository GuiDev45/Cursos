package application;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class Program {

	public static void main(String[] args) {
		
		String[] lines = new String[] { "Good morning", "Good afternoon", "Good night" };
		
		//Cria o arquivo .txt
		String path = "C:\\temp\\out.txt";
		
		//Salva o que está no vetor dentro do arquivo .txt
		//O true faz com que o arquivo não seja recriado, caso rode o compilador novamente, ele vai acrescentar novamente o que está no vetor.
		try (BufferedWriter bw = new BufferedWriter(new FileWriter(path, true))) {
			for (String line : lines) {
				bw.write(line);
				bw.newLine();
			}
		}
		catch (IOException e) {
			e.printStackTrace();
		}
	}
}
