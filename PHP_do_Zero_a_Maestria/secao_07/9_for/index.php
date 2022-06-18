<?php

$j = 0;
$nome = "Guilherme";

for ($i = 0; $i < 10; $i++) {

    if ($i == 4) {
        echo "$nome <br>";
    }

    if ($i == 8) {
        break;
    }

    echo "Testando for $i <br>";

}

//Saída
/*
Testando for 0
Testando for 1
Testando for 2
Testando for 3
Guilherme
Testando for 4
Testando for 5
Testando for 6
Testando for 7
*/

?>