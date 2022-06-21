<?php

    function parOuImpar($num) {
        if ($num % 2 === 0) {
            echo "O número $num: é par <br>";
        }
        else {
            echo "O número $num: é ímpar <br>";
        }
    }

    parOuImpar(30);
    parOuImpar(31);
    parOuImpar(22);
    parOuImpar(11);

    //Saída
    /*
    O número 30: é par
    O número 31: é ímpar
    O número 22: é par
    O número 11: é ímpar
    */

?>