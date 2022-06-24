<?php

    class Pessoa {
        public $nome;
        public $idade;

        function andar($n) {
            echo "A pessoa anda $n metros <br>";
        }
    }

    $joao = new Pessoa;
    $joao -> nome = "João";
    $joao -> idade = 25;

    echo "O nome dele é $joao->nome e tem $joao->idade anos <br>";
    $joao -> andar(525);

    $maria = new Pessoa;
    $maria -> maria = "Maria";
    $maria -> maria = 20;
    
    echo "O nome dela é $maria->nome e tem $maria->idade anos <br>";
    $maria -> andar(320);

    //Saída
    /*
    O nome dele é João e tem 25 anos
    A pessoa anda 525 metros
    O nome dela é e tem anos
    A pessoa anda 320 metros
    */
    
?>