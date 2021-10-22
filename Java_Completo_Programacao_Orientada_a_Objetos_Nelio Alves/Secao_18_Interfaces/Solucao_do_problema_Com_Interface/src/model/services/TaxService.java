package model.services;

//TaxService é um tipo mais generico, diferente do BrazilTaxService que é um tipo mais concreto,
//Caso exista outra classe de imposto, ex UsaTaxService essa classe vai passar pelo contrato/interface TaxService
public interface TaxService {

	double tax(double amount);
}
