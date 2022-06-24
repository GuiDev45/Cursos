<?php
//Constantes "são tipos" variáveis que não podem ser mudadas.

    class Humano {

        public const OLHOS = 2;
        public const BRACOS = 2;
        public const PERNAS = 2;

        function mostrarConstante() {
            echo self::BRACOS . "<br>"; //A sintaxe também vale para função/método
        }

    }

    $matheus = new Humano;

    echo $matheus::OLHOS . "<br>"; //É o mesmo que $matheus->OLHOS, mas se chama com ::

    $matheus->mostrarConstante();

    //Saída
    /*
    2
    2
    */

?>