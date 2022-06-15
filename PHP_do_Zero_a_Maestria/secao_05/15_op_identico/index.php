<?php

if (5 == "5") {
    echo "5 é 5 1<br>";
}

// Operador idêntico === , além de ver se o valor é igual, também olha se o tipo é igual.

if (5 === "5") {//Não é idêntico
    echo "5 é 5 2<br>";
}

if (5 === 5) {//É idêntico
    echo "5 é 5 3<br>";
}

//Saída
/*
5 é 5 1
5 é 5 3
*/

?>