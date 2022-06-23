<?php

    $carro = [
        'marca' => 'BMW',
        'motor' => '2.4',
        'teto_solar' => true,
        'cambio' => 'Manual',
        'portas' => 4
    ];

    $chaves = array_keys($carro);

    print_r($chaves);
    echo "<br>";

    $valores = array_values($carro);

    print_r($valores);
    echo "<br>";

    //Saída
    /*
    Array ( [0] => marca [1] => motor [2] => teto_solar [3] => cambio [4] => portas )
    Array ( [0] => BMW [1] => 2.4 [2] => 1 [3] => Manual [4] => 4 )
    */

?>