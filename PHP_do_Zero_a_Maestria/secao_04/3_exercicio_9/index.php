<?php

//Lembrando que em php "não" tem o casting não vai reclamar de int fazendo operação com float etc.

$a = 11; //int
$b = 99.324; //float

$c = $a + $b;

echo $c;

//Saída
/*
110.324
*/

?>