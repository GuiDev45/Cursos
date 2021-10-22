package entities;

public class OutsourcedEmployee extends Employee{

	private Double additionalCharge;

	public OutsourcedEmployee() {
	}
	
	public OutsourcedEmployee(String name, Integer hours, Double valuePerHour, Double additionalCharge) {
		super(name, hours, valuePerHour);
		this.additionalCharge = additionalCharge;
	}

	public Double getAdditionalCharge() {
		return additionalCharge;
	}

	public void setAdditionalCharge(Double additionalCharge) {
		this.additionalCharge = additionalCharge;
	}
	
	//Como a regra do payment nesta classe é diferente é usado o @Override/sobrescrever essa regra.
	//O super.payment é herdado para montar a nova regra utilizando o atributo additionalCharge.
	@Override
	public double payment() {
		return super.payment() + additionalCharge * 1.1;
	}
	
}
