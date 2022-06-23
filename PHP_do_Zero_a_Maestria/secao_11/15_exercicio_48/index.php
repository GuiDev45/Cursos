<?php

    $arr = ['batata', 'maçã', 'pera', 'feijão', 'arroz'];

    array_splice($arr, 2, 2);

    print_r($arr);

    echo "<br>";

    //Saída
    /*
    Array ( [0] => batata [1] => maçã [2] => arroz )
    */

?>