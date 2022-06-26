<?php

    $dataNascimento = mktime(02, 12, 33, 02, 05, 1991);

    echo $dataNascimento . "<br>";

    $dataNascimentoFormatada = date('d/m/y', $dataNascimento);

    echo $dataNascimentoFormatada . "<br>";

    $dataEspecifica = mktime(10, 20, 11, 04, 28, 2041);

    $dataFuturaFormatada = date('m/d/y', $dataEspecifica);

    //Saída
    /*
    665716353
    05/02/91
    */

?>