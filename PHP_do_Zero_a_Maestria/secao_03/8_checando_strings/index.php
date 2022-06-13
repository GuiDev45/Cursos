<?php

$str = "Guilherme";//$str é realmente uma variável string.
$num = 12;

if (is_string($str)) {
    echo "$str é uma string 1<br>";
}

if (is_string($num)) {
    echo "$num é uma string 2<br>";
}

if (is_string("asd")) {
    echo "É uma string 3<br>";
}

//Saída
/*Guilherme é uma string 1
É uma string 3*/

?>