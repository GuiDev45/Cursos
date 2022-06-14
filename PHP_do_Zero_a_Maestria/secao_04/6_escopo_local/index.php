<?php

$x = 10;
echo "$x global <br>";

function teste() {//Escopo da função
    $x = 5;
    echo "$x local <br>";
}

teste(); //Saída da função

//Saída
/*
10 global
5 local
*/

?>