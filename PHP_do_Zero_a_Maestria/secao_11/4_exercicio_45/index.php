<?php

    $arr = range(10, 45);

    for ($i = 0; $i < count($arr); $i++) {
        $soma = $arr[$i] + 6;

        if ($soma > 30) {
            echo "O número $soma é muito alto <br>";
        }
        else {
            echo "$soma <br>";
        }
    }

    //Saída
    /*
    16
    17
    18
    19
    20
    21
    22
    23
    24
    25
    26
    27
    28
    29
    30
    O número 31 é muito alto
    O número 32 é muito alto
    O número 33 é muito alto
    O número 34 é muito alto
    O número 35 é muito alto
    O número 36 é muito alto
    O número 37 é muito alto
    O número 38 é muito alto
    O número 39 é muito alto
    O número 40 é muito alto
    O número 41 é muito alto
    O número 42 é muito alto
    O número 43 é muito alto
    O número 44 é muito alto
    O número 45 é muito alto
    O número 46 é muito alto
    O número 47 é muito alto
    O número 48 é muito alto
    O número 49 é muito alto
    O número 50 é muito alto
    O número 51 é muito alto
    */
    
?>