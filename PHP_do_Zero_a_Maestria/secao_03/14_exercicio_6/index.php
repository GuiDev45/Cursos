<?php

$carro = [
    'marca' => 'BMW',
    'rodas' => 4,
    'teto_solar' => true,
    'velocidade_max' => 300,
    'blindado' => false
];

print_r($carro);

$marca = $carro['marca'];//É como se a variável marca tivesse recebendo o valor do índice [0]
$velocidade_maxima = $carro['velocidade_max'];//É como se a variável velocidade_maxima tivesse recebendo o valor do índice [3]

echo "<br>";

echo "O carro é da marca $marca e atinge no máximo $velocidade_maxima km/h";

//Saída
/*
Array ( [marca] => BMW [rodas] => 4 [teto_solar] => 1 [velocidade_max] => 300 [blindado] => )
O carro é da marca BMW e atinge no máximo 300 km/h
*/

?>