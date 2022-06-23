<?php

    $carro = ["Jaguar", 3.0, "Azul", 18, "Teto solar", "Automático"];

    list($marca, $motor, $cor, $aro, $opicional, $cambio) = $carro;

    echo "$marca <br>";
    echo "$motor <br>";
    echo "$cor <br>";
    echo "$aro <br>";
    echo "$opicional <br>";
    echo "$cambio <br>";

    print_r($carro);

    //Saída
    /*
    Jaguar
    3
    Azul
    18
    Teto solar
    Automático
    Array ( [0] => Jaguar [1] => 3 [2] => Azul [3] => 18 [4] => Teto solar [5] => Automático )
    */

?>