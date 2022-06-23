<?php

    $pessoa = ["Matheus", 29, "Programador", "verde"];

    print_r($pessoa);
    echo "<br>";

    list($nome, $idade, $profissao, $corDosOlhos) = $pessoa;

    echo "$nome <br>";
    echo "$idade <br>";
    echo "$profissao <br>";
    echo "$corDosOlhos <br>";

    //Saída
    /*
    Array ( [0] => Matheus [1] => 29 [2] => Programador [3] => verde )
    Matheus
    29
    Programador
    verde
    */
    
?>