<?php

$a = [1, 2, 3];//Declarando um array.

print_r($a);//print_r é uma função especial para imprimir um array.
echo "<br>";
echo $a[0];//Imprimi o valor que está no índice 0

$arr = ["Guilherme", 1005, true];//O php aceita diferentes dentro do array, porém não acho recomendado.

echo "<br>";
print_r($arr);//print_r é uma função especial para imprimir um array.
echo "<br>";
print_r($arr[1]);//Vai imprimir o que está no índice 1 do array, no caso 1005

//Saída
/*
Array ( [0] => 1 [1] => 2 [2] => 3 )
1
Array ( [0] => Guilherme [1] => 1005 [2] => 1 )
1005
*/

?>