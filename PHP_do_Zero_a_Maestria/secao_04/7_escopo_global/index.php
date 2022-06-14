<?php

$teste = "abc";

echo "$teste global 1 <br>";

if(true) {
    $teste = "cde"; //Escopo global recebendo cde
    echo "$teste if <br>";
}

echo "$teste global 2 <br>";

function funcao() {
    $teste = "ZZZ";
    echo "$teste local <br>"; //Saída: local
}

funcao();

function funcao2() {
    global $teste; //Passando o que foi atribuido no escopo global então cde
    echo $teste; //Saída: cde
}

funcao2();

//Saída
/*
abc global 1
cde if
cde global 2
ZZZ local
cde
*/

?>