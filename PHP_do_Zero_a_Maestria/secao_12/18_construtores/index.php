<?php

    class Car {

        public $portas;
        public $cor;
        public $marca;

        function __construct($portas, $cor, $marca)
        {
            $this->portas = $portas;
            $this->cor = $cor;
            $this->marca = $marca;
        }

    }

    $ferrari = new Car(4, "Vermelha", "Ferrari");

    echo "O carro é da marca $ferrari->marca e tem a cor $ferrari->cor <br>";

    //Saída
    /*
    O carro é da marca Ferrari e tem a cor Vermelha
    */

?>