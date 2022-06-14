<?php

function teste() {

    $a = 0;
    $a++;

    echo "$a <br>";

}

teste();
teste();
teste();

//static mantém o valor, então nesse caso vai incrementar cada vez que for impresso.
//Porém não é comum criar variáveis do tipo static.
function testeStatic() {

    static $a = 0;
    $a++;

    echo "$a <br>";

}

testeStatic();
testeStatic();
testeStatic();

//Saída
/*
1
1
1
1
2
3
*/

?>