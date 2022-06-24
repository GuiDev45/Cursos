<?php

    class Car {

        public $rodas = 4;//Atributos sendo publicos
        public $aro = 20;
        public $cor = "Vermelha";

        function ligar() {
            echo "Vrummmm <br>";
        }

    }

    $ferrari = new Car;

    echo $ferrari -> aro . "<br>";
    echo $ferrari -> rodas . "<br>";

    $ferrari -> cor = "Azul <br>"; //Alterando o atributo cor, de Vermelha para Azul

    echo $ferrari -> cor;

    echo $ferrari -> ligar();

    //Saída
    /*
    20
    4
    Azul
    Vrummmm
    */

?>