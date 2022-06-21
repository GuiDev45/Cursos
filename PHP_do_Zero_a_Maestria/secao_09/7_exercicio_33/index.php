<?php

    function apresentarPessoa($nome, $idade, $genero) {
        echo "Olá eu sou $genero $nome e tenho $idade anos <br>";
    }

    apresentarPessoa("Matheus", 29, "o");
    apresentarPessoa("Alexia", 24, "a");
    
    //Saída
    /*
    Olá eu sou o Matheus e tenho 29 anos
    Olá eu sou a Alexia e tenho 24 anos
    */

?>