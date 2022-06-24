<?php

    class Cachorro {

        function latir() {
            echo "Au au <br>";
        }

        function andar($n) {
            echo "o cachorro andou $n metros <br>";
        }

    }

    $cachorro1 = new Cachorro;
    $cachorro1 -> latir();
    $cachorro1 -> andar(830);

    $cachorro2 = new Cachorro;
    $cachorro2 -> latir();
    $cachorro2 -> andar(270);

    //Saída
    /*
    Au au
    o cachorro andou 830 metros
    Au au
    o cachorro andou 270 metros
    */

?>