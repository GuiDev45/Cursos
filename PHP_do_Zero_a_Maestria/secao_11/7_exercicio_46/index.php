<?php

    $arr = [
        [1, 2, 3, 4],
        [2, 4, 6, 8],
        [3, 6, 9, 12]
    ];

    //Loop no array externo
    for ($i = 0; $i < count($arr); $i++) {

        //Imprimindo array
        echo "Imprimindo array externo: " . ($i + 1) . "<br>";

        //Imprimindo o array interno
        for ($j = 0; $j < count($arr[$i]); $j++) {
            echo $arr[$i][$j] . "<br>";
        }
    }

    //Saída
    /*
    Imprimindo array externo: 1
    1
    2
    3
    4
    Imprimindo array externo: 2
    2
    4
    6
    8
    Imprimindo array externo: 3
    3
    6
    9
    12
    */
    
?>