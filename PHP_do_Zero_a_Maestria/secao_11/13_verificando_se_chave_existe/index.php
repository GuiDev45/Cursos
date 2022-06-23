<?php

    $arr = [
        'nome' => 'Matheus',
        'idade' => 29
    ];

    if (array_key_exists("nome", $arr)) {
        echo "A chave existe! <br>";
    }
    else {
        echo "Acha não existe! <br>";
    }

    //Outra forma
    if (isset($arr['nome'])) {
        echo "A chave existe! <br>";
    }
    else {
        echo "Acha não existe! <br>";
    }

    //Saída
    /*
    A chave existe!
    A chave existe!
    */

?>