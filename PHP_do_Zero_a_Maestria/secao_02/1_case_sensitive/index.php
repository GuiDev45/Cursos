<?php

//Não é case sensitive
echo "teste <br>";
eCho "testando 2 <br>";
ECHO "testando 3 <br>";

//É case sensitive
$nome = "Guilherme";//$ é a forma de declarar variável.
$NOME = "Teste";

echo $nome;
echo "<br>";//<br> quebra a linha.
echo $NOME;

//Saída
/*teste
testando 2
testando 3
Guilherme
Teste*/

?>