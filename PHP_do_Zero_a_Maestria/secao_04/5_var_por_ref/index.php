<?php

//Variável por referência é como se uma virasse cópia da outra, o que afetar em uma afeta na outra.

$x = 10;

$y =& $x; //Geralmente isso não é usado, é melhor fazer uma atribuição direta mesmo.

echo $x;
echo "<br>";
echo $y;
echo "<br>";

$y = 15;

echo "Atribuição após ref";
echo "<br>";
echo $x;
echo "<br>";
echo $x;

//Saída
/*
10
10
Atribuição após ref
15
15
*/

?>