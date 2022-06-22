<?php

    $frase = "O rato roeu a roupa do Rei de Roma"; //4 letras a

    $contAs = 0;

    for ($i = 0; $i < strlen($frase); $i++) {

        if ($frase[$i] === "a") {
            $contAs++;
        }

    }

    echo "O número de a's na frase é de : $contAs";

    //Saída
    /*
    O número de a's na frase é de : 4
    */
    
?>