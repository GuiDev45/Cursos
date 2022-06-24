<?php

    class Animal {

        public $nome; //$nome do atributo

        function escolherNome($nome) {
            $this->nome = $nome; //this está apontando para o $nome do atributo.
        }

        function latir() { //Esse latir
            return "Au au <br>";
        }

        //Chamando métodos do próprio objeto usando o $this
        function latirForte() {
            return strtoupper($this->latir()); //Esse latir
        }
    }

    $frida = new Animal;

    echo "O nome do animal é: $frida->nome <br>"; //Não vai imprimir nada.

    $frida->escolherNome("Frida");

    echo "O nome do animal é: $frida->nome <br>";

    echo $frida->latir();

    echo $frida->latirForte();

    //Saída
    /*
    O nome do animal é:
    O nome do animal é: Frida
    Au au
    AU AU
    */

?>