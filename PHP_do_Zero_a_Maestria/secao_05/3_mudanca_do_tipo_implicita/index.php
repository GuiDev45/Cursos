<?php

//Cuidado com o auto casting.

echo 5 / 2;
echo "<br>";

if (is_float(5 / 2)) {
    echo "É float <br>";
}

echo 2 . 3;
echo "<br>";

if (is_string(2 . 3)) {
    echo "É string <br>";
}

$nome = "Guilherme";
$sobrenome = "Bortoletto";

$nomeCompleto = $nome . " " . $sobrenome; //Isso é concatenar em php.

echo $nomeCompleto;
echo "<br>";

//Saída
/*
2.5
É float
23
É string
Guilherme Bortoletto
*/

?>