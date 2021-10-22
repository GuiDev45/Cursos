package model.entities;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class Reservation {

	private Integer roomNumber;
	private Date checkIn;
	private Date checkOut;
	
	//O dado sdf está estático para que não seja instanciado um no sdf para cada objeto Reservation que a aplicação tiver,
	//Vai ser necessário apenas um por isso está static.
	private static SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
	
	public Reservation() {
	}

	public Reservation(Integer roomNumber, Date checkIn, Date checkOut) {
		super();
		this.roomNumber = roomNumber;
		this.checkIn = checkIn;
		this.checkOut = checkOut;
	}

	public Integer getRoomNumber() {
		return roomNumber;
	}

	public void setRoomNumber(Integer roomNumber) {
		this.roomNumber = roomNumber;
	}

	public Date getCheckIn() {
		return checkIn;
	}

	public Date getCheckOut() {
		return checkOut;
	}
	
	//long é um tipo inteiro mais longo.
	//Esse bloco calcula a diferença entre as datas em milissegundos, que é o mais natural da plataforma Java.
	public long duration() {
		//.getTime me devolve a quantidade de milissegundos da data checkOut e da data checkIn,
		//Com isso se pega a diferença entre as datas em milissegundos.
		long diff = checkOut.getTime() - checkIn.getTime();
		//Essa linha converte os milissegundos para dias,
		//Essa classe TimeUnit é um tipo enumerado complexo com algumas operações.
		return TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
	}
	
	//Esse método que é o responsavel por atualizar as datas.
	public void updateDates(Date checkIn, Date checkOut) {
		Date now = new Date();
		//Se as datas forem antes da data atual.
		if (checkIn.before(now) || checkOut.before(now)) {
			throw new DomainException("Reservation dates for update must be future dates");
		}
		if (!checkOut.after(checkIn)) {
			throw new DomainException("Check-out date must be after check-in date");
		}
		this.checkIn = checkIn;
		this.checkOut = checkOut;
	}
	
	@Override
	public String toString() {
		return "Room " 
			+ roomNumber 
			+ ", check-in: " 
			+ sdf.format(checkIn) 
			+ ", check-out: " 
			+ sdf.format(checkOut) 
			+ ", " 
			+ duration() 
			+ " nights";
	}
	
}
