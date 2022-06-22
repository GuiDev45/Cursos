<?php

    $frase1 = "testando o case de uma palavra <br>";
    $frase2 = "Testando o case de uma palavra <br>";
    $frase3 = "testando o case de uma palavra <br>";

    //Primeira letra em maiúsculo
    echo ucfirst($frase1);
    echo ucfirst($frase2);

    //Todas as palavras com as iniciais maiúsculas
    echo ucwords($frase3);
    echo ucwords($frase2);

    //Saída
    /*
    Testando o case de uma palavra
    Testando o case de uma palavra
    Testando O Case De Uma Palavra
    Testando O Case De Uma Palavra
    */

?>