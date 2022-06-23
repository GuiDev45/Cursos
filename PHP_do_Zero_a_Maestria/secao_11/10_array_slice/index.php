<?php

    $arr = [2, 4, 6, 8, 10, 12, 14, 16, 18];

    $slice1 = array_slice($arr, 1, 3);

    print_r($slice1);
    echo "<br>";

    //Saída
    /*
    Array ( [0] => 4 [1] => 6 [2] => 8 )
    */

?>