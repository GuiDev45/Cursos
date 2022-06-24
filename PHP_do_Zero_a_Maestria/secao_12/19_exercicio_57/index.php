<?php

    class Cachorro {

        public $nome;
        public $cor;
        public $patas;

        function __construct($nome, $cor, $patas)
        {
            $this->nome = $nome;
            $this->cor = $cor;
            $this->patas = $patas;
        }

        public function exibirAnimal() {
            echo "O nome do cachorro é $this->nome, ele tem a cor $this->cor, e tem $this->patas patas <br>";
        }

    }

    $turca = new Cachorro("Turca", "Preta", 4);

    $turca->exibirAnimal();

    $nome = "Tubarão";
    $cor = "Branca";
    $patas = 4;

    $tubarao = new Cachorro ($nome, $cor, $patas);

    $tubarao->exibirAnimal();

    //Saída
    /*
    O nome do cachorro é Turca, ele tem a cor Preta, e tem 4 patas
    O nome do cachorro é Tubarão, ele tem a cor Branca, e tem 4 patas
    */

?>