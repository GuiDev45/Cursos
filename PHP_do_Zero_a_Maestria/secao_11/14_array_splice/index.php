<?php

    $arr = [1, 2, 3, 4, 5, 6];

    $removidos = array_splice($arr, 1, 2);

    print_r($arr);
    echo "<br>";

    print_r($removidos);
    echo "<br>";

    //Saída
    /*
    Array ( [0] => 1 [1] => 4 [2] => 5 [3] => 6 )
    Array ( [0] => 2 [1] => 3 )
    */
    
?>