<?php

    $arr1 = [1, 2, 3];
    $arr2 = [10, 20, 30];
    $arr3 = [1.5, 2.5, 3.5];

    $arrMerge = array_merge($arr1, $arr2, $arr3);

    print_r($arrMerge);
    echo "<br>";

    //Saída
    /*
    Array ( [0] => 1 [1] => 2 [2] => 3 [3] => 10 [4] => 20 [5] => 30 [6] => 1.5 [7] => 2.5 [8] => 3.5 )
    */

?>