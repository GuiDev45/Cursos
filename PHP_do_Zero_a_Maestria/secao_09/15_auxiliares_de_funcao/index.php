<?php

    function soma($a, $b, $c) {
        print_r(func_get_args()); //Os argumentos que foram passados.

        echo "<br>";

        echo func_num_args() . "<br>"; //Quantidade de argumentos.

        return $a + $b;
    }

    soma(2, 4, 5);

    //Saída
    /*
    Array ( [0] => 2 [1] => 4 [2] => 5 )
    3
    */

?>