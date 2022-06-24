<?php

    class Humano {

        public $idade = 29;

        public function falar() {
           echo "Olá Mundo!";
        }

        private function gritar() { //Como é private, precisa ter algo público para acessar essa função/método
            echo "PHP É MUITO BOM! <br>";
        }

        public function acessaGritar() { //O "algo público"
            $this->gritar();
        }

        protected function falarBaixinho() {
            echo "lalala <br>";
        }

        public function acessarFalarBaixinho() {
            $this->falarBaixinho();
        }

    }

    class Programador extends Humano { //Está extendendo a classe Humano, então os recursos da classe Humano podem ser usados aqui.

        public function acessarFalarBaixinhoProgramador() { //Como é protected é possível acessar em outra classe Humano, fazendo assim a herança.
            $this->falarBaixinho();
        }

    }

    $ze = new Humano;

    $ze->falar();
    $ze->acessaGritar();
    $ze->acessarFalarBaixinho();

    $matheus = new Programador;

    echo $matheus->idade . "<br>";

    $matheus->falar();
    $matheus->acessaGritar();
    $matheus->acessarFalarBaixinhoProgramador();

    //Saída
    /*
    Olá Mundo!PHP É MUITO BOM!
    lalala
    29
    Olá Mundo!PHP É MUITO BOM!
    lalala
    */

?>