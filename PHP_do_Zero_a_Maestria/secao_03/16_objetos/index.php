<?php

class Pessoa {

    function falar() {
        echo "Olá pessoal!";
    }

}

//Criando objeto guilherme com a classe Pessoa.
$guilherme = new Pessoa();

//Adicionando uma propriedade para Pessoa.
$guilherme -> nome = "Guilherme";

//Imprimindo essa propriedade criada.
echo $guilherme -> nome;

echo "<br>";

//Declarando a função da classe Pessoa.
$guilherme -> falar();

//Saída
/*
Guilherme
Olá pessoal!
*/

?>