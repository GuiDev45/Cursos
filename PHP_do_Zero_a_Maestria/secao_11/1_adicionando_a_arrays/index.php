<?php

    $arr = [];

    print_r($arr);
    echo "<br>";

    $arr[0] = 10;

    print_r($arr);
    echo "<br>";

    $arr[1] = 15;

    print_r($arr);
    echo "<br>";

    $arr[5] = 25;

    print_r($arr);
    echo "<br>";

    //Modificar valores
    $arr[1] += 55;

    print_r($arr);
    echo "<br>";

    $arrAssoc = [];

    print_r($arrAssoc);
    echo "<br>";

    $arrAssoc["carro"] = "BMW";

    print_r($arrAssoc);
    echo "<br>";

    $arrAssoc["aviao"] = "boeing";

    print_r($arrAssoc);
    echo "<br>";

    $arrAssoc["carro"] = "Ferrari";

    print_r($arrAssoc);
    echo "<br>";

    //Saída
    /*
    Array ( )
    Array ( [0] => 10 )
    Array ( [0] => 10 [1] => 15 )
    Array ( [0] => 10 [1] => 15 [5] => 25 )
    Array ( [0] => 10 [1] => 70 [5] => 25 )
    Array ( )
    Array ( [carro] => BMW )
    Array ( [carro] => BMW [aviao] => boeing )
    Array ( [carro] => Ferrari [aviao] => boeing )
    */
    
?>