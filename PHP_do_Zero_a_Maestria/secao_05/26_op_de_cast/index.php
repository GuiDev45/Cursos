<?php

$a = (int) "12";

echo $a;
echo "<br>";
echo $a + 10;
echo "<br>";

if ($a === 12) {
    echo "A é idêntico a 12 <br>";
}

$b = (float) "3.14";//vai realmente converter para float

if ($b === 3.14) {
    echo "B é idêntico a 3.14 <br>";
}

//Saída
/*
12
22
A é idêntico a 12
B é idêntico a 3.14
*/

?>