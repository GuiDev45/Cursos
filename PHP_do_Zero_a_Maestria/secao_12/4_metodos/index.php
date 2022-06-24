<?php

    class Pessoa {

        function falar() {//function é o método do php.
            echo "Olá, eu sou um objeto! <br>";
        }

        function somar($x, $y) {
            echo $x + $y . "<br>";
        }

    }

    $matheus = new Pessoa;//instanciando a classe Pessoa em matheus.

    $matheus -> falar();//executando o método da classe Pessoa.

    $joao = new Pessoa;

    $joao -> falar();

    $matheus -> somar(2, 2);//colocando atributo em um método com atributos.

    $joao -> somar(10, 5);

    //Saída
    /*
    Olá, eu sou um objeto!
    Olá, eu sou um objeto!
    4
    15
    */

?>