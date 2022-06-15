<?php

//basicamente é o contrário do operador de igualdade ==

$a = 3;
$b = 4;

if ($a != $b) {
    echo "Testando diferença 1<br>";
}

if ($a != 3) {
    echo "Testando diferença 2<br>";
}

if (false != "teste") {
    echo "Testando diferença 3<br>";
}

//Saída
/*
Testando diferença 1
Testando diferença 3
*/

?>