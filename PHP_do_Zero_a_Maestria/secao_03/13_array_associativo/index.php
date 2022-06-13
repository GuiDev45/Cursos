<?php

//Array associativo é basicamente trocar o valor dos índices por strings.

$arr = ['nome' => 'Shark', 'patas' => 4, 'cor' => 'Marrom'];

echo $arr['nome'];//Imprimindo só o nome
echo "<br>";
print_r($arr);
echo "<br>";
echo $arr['patas'];

$arrAssoc = ['chave' => 'valor', 'bool' => true];

echo "<br>";
print_r($arrAssoc);

//Saída
/*
Shark
Array ( [nome] => Shark [patas] => 4 [cor] => Marrom )
4
Array ( [chave] => valor [bool] => 1 )
*/

?>