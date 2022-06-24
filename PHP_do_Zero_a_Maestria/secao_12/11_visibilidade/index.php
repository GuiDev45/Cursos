<?php

    class Car {

        public $rodas = 4;
        private $vidro = "sem película"; //Só pode ser acessado pela classe de fato.

        public function getVidro() { //Só pode ser acessado pela classe de fato.
            return $this->vidro;
        }

    }

    class Mecanico {

        public function alterarRodas($carro) {
            $carro->rodas = 10;
        }

        public function colocarPelicula($carro, $pelicula) {
            $carro->vidro = $pelicula;
        }

    }

    $carro = new Car;

    echo $carro->rodas . "<br>";

    $matheus = new Mecanico;

    $matheus->alterarRodas($carro);

    echo $carro->rodas . "<br>";

    //Não pode alterar porque é privado.
    //$matheus->colocarPelicula($carro, "G20");

    echo $carro->getVidro() . "<br>"; //Acessando a propriedade

    //Saída
    /*
    4
    10
    sem película
    */

?>