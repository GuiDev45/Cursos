<?php

echo "Testando texto de aspas duplas <br>";
echo 'Testando texto de aspas simples <br>';
echo "Ele disse: 'Olá! <br>";
echo 'Ele disse: "Olá!" <br>';

$idade = 15;

echo "Ele tem $idade anos <br>";//O php consegue concatenar a variável "do tipo int" dentro da string de uma forma simples.
echo 'Ele tem $idade anos';//Porém isso não funciona com aspas simples.

//Saída
/*Testando texto de aspas duplas
Testando texto de aspas simples
Ele disse: 'Olá!
Ele disse: "Olá!"
Ele tem 15 anos
Ele tem $idade anos*/

?>