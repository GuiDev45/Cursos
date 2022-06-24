<?php

    abstract class Teste {

        public static function testandoClasse() { //A função/método precisa ser static
            echo "Este método é de uma classe abstrata <br>";
        }

        abstract public function testeAbs();
    }

    //Não da para chamar o método da classe abstrata.
    //$t = new Teste;

    //A ideia é poder chamar o conteúdo da classe sem que ela esteja instanciada.
    Teste::testandoClasse();

    class Nova extends Teste {

        public function testeAbs() {
            echo "teste método abstrato <br>";
        }

    }

    $n = new Nova;
    $n->testeAbs();

    //Saída
    /*
    Este método é de uma classe abstrata
    teste método abstrato
    */

?>