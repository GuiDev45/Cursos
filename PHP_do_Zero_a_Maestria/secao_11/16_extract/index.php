<?php

    $arr = [
        'cor' => 'vermelho',
        'forma' => 'retângular',
        'material' => 'aço'
    ];

    extract($arr);

    echo "$cor <br>";
    echo "$forma <br>";
    echo "$material <br>";

    //Saída
    /*
    vermelho
    retângular
    aço
    */

?>