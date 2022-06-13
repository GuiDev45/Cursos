<?php

//Alguns valores são considerados como falsos: 0, 0.0, "0", [], NULL
//Básicamente zeros, arrays vazias e null.

echo true;//1 para verdadeiro
echo "<br>";
echo false;//0 para false

if (true) {
    echo "È verdadeiro! <br>";
}

if (5 > 2) { //true
    echo "É verdadeiro! <br>";
}

$podeEntrar = true;

if ($podeEntrar) {
    echo "O usuário pode entrar";
}

//Saída
/*1
È verdadeiro!
É verdadeiro!
O usuário pode entrar*/

?>