package model.services;

import java.security.InvalidParameterException;

public interface InterestService {

	double getInterestRate();

	default double payment(double amount, int months) {
		if (months < 1) {
			throw new InvalidParameterException("Months must be greater than zero");
		}
		//Usa a chamada do metodo para pegar o juros da classe especifica.
		return amount * Math.pow(1.0 + getInterestRate() / 100.0, months);
	}
}
