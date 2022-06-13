<?php

$a = true;

if (is_bool($a)) {
    echo "É um booleano 1 <br>";
}

if (is_bool(0)) {
    echo "É um booleano 2 <br>";
}

if (is_bool(false)) {
    echo "É um booleano 3 <br>";
}

if (0.0 == false) {
    echo "É um booleano 4 <br>";
}

//Saída
/*É um booleano 1
É um booleano 3
É um booleano 4*/

?>