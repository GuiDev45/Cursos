<?php

$x = 4;
$limite = 30;

while ($x < $limite) {
    echo "Executando o loop $x <br>";

    if ($x === 24) {
        echo "Parando o loop";
        break;
    }

    $x += 2;
}

//Saída
/*
Executando o loop 4
Executando o loop 6
Executando o loop 8
Executando o loop 10
Executando o loop 12
Executando o loop 14
Executando o loop 16
Executando o loop 18
Executando o loop 20
Executando o loop 22
Executando o loop 24
Parando o loop
*/

?>