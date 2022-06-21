<?php

    $arr = [
        "Teste",
        123,
        12393.3452,
        true,
        [1,2,3]
    ];

    print_r($arr);

    echo "<br>";

    var_dump($arr); //Em resumo ele detalha mais as informações.

    //Saída
    /*
    Array ( [0] => Teste [1] => 123 [2] => 12393.3452 [3] => 1 [4] => Array ( [0] => 1 [1] => 2 [2] => 3 ) )
    array(5) { [0]=> string(5) "Teste" [1]=> int(123) [2]=> float(12393.3452) [3]=> bool(true) [4]=> array(3) { [0]=> int(1) [1]=> int(2) [2]=> int(3) } }
    */

?>