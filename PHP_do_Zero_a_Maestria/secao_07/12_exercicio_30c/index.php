<?php

$arr = [];

for ($i = 10; $i <= 20; $i++) {
    array_push($arr, $i);
}

print_r($arr);
echo "<br>";

for ($i = 0; $i < count($arr); $i++) {
    if ($arr[$i] % 2 != 0) {
        echo "Número ímpar: $arr[$i] <br>";
    }
}

//Saída
/*
Array ( [0] => 10 [1] => 11 [2] => 12 [3] => 13 [4] => 14 [5] => 15 [6] => 16 [7] => 17 [8] => 18 [9] => 19 [10] => 20 )
Número ímpar: 11
Número ímpar: 13
Número ímpar: 15
Número ímpar: 17
Número ímpar: 19
*/

?>