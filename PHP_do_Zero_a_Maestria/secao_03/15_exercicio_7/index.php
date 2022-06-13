<?php

$pessoa1 = [
    'nome' => 'Maria',
    'altura' => 1.60,
    'peso' => 68,
    'idade' => 20
];

$pessoa2 = [
    'nome' => 'João',
    'altura' => 1.90,
    'peso' => 92,
    'idade' => 26
];

if ($pessoa1['idade'] > $pessoa2['idade']) {
    echo "Pessoa 1 é mais velha.";
}
else {
    echo "Pessoa 2 é mais velha.";
}

echo "<br>";

echo "Todos os dados.";
echo "<br>";
print_r($pessoa1);
echo "<br>";
print_r($pessoa2);

//Saída
/**/

?>