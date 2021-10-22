package model.entities;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;

public class Reservation {

	private Integer roomNumber;
	private Date checkIn;
	private Date checkOut;
	
	//O dado sdf est� est�tico para que n�o seja instanciado um no sdf para cada objeto Reservation que a aplica��o tiver,
	//Vai ser necess�rio apenas um por isso est� static.
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
	
	//long � um tipo inteiro mais longo.
	//Esse bloco calcula a diferen�a entre as datas em milissegundos, que � o mais natural da plataforma Java.
	public long duration() {
		//.getTime me devolve a quantidade de milissegundos da data checkOut e da data checkIn,
		//Com isso se pega a diferen�a entre as datas em milissegundos.
		long diff = checkOut.getTime() - checkIn.getTime();
		//Essa linha converte os milissegundos para dias,
		//Essa classe TimeUnit � um tipo enumerado complexo com algumas opera��es.
		return TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
	}
	
	//Esse m�todo que � o responsavel por atualizar as datas.
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
