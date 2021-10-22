package model.services;

//TaxService � um tipo mais generico, diferente do BrazilTaxService que � um tipo mais concreto,
//Caso exista outra classe de imposto, ex UsaTaxService essa classe vai passar pelo contrato/interface TaxService
public interface TaxService {

	double tax(double amount);
}
